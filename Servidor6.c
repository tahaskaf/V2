#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <mysql.h>
#include <pthread.h>

//------------------------------------------------------------------------------
int contador;
//Estructura para acceso excluyente
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;

//------------------------------------------------------------------------------
//Variables:
//	SQL:
MYSQL *conn;
int err;
MYSQL_RES *resultado;
MYSQL_ROW row;

int sockets[100];

//------------------------------------------------------------------------------
//Estructuras:
typedef struct {
	//Declaramos una estructura que almacena un nombre y su socket
	char nombre[20];
	int socket;
}Conectado;

typedef struct {
	Conectado conectados[100];
	int num;
}ListaConectados;


ListaConectados miLista;

//------------------------------------------------------------------------------
//Funciones:
int Add (ListaConectados *lista, char nombre[20],int socket){
	//Añade un nuevo conectado. Si la lista esta llena retorna -1 y si ha 
	//añadido con exito al nuevo jugador retorna 0
	if (lista->num==100)
		return -1;
	else{
		strcpy(lista->conectados[lista->num].nombre,nombre);
		lista->conectados[lista->num].socket = socket;
		lista->num++;
		return 0;
	}
}

int SearchPosition (ListaConectados *lista, char nombre[20]){
	//Devuelve la posicion o -1 si no lo encuentra.
	int i =0;
	int encontrado=0;
	while ((i<100) && (!encontrado)){
		if (strcmp(lista->conectados[i].nombre,nombre)==0)
			encontrado=1;
		else{
			i=i+1;
		}
	}
	if (encontrado == 1)
		return i;
	else{
		return -1;
	}
}

int Disconect (ListaConectados *lista, char nombre[20]){
	//retorna 0 si el usuario se ha desconectado con exito y -1 si ha ocurrido 
	//un error
	int pos = SearchPosition(lista, nombre);
	int i;
	//la no se recibe por referncia pues ya la recibimos por referencia el en disconnect
	if (pos==-1){
		return -1;
	}
	else{
		for (i=pos; i<lista->num-1;i++){
			lista ->conectados[i] = lista->conectados[i+1];
			strcpy(lista->conectados[i].nombre, lista->conectados[i+1].nombre);
			lista->conectados[i].socket==lista->conectados[i+1].socket;
		}
		lista->num--;
		return 0;
	}
}

/*int Delete (ListaConectados *lista, char nombre[20]){
	//retorna 0 si elimina a la persona y -1 si ese usuario no esta conectado.
	int pos = DameSocket (lista,nombre);
	if (pos == -1)
	{
		return -1;
	}
	else
	{
		int i;
		for (i = pos; i < lista->num-1; i++)
		{
			strcpy(lista->conectados[i].nombre, lista->conectados[i+1].nombre);
			lista->conectados[i].socket = lista->conectados[i+1].socket;
		}
		lista->num--;
		return 0;
	}
}*/

void DameConectados (ListaConectados *lista,char conectados [500]){
	//Devuelve llena la lista conectados. Esta se llenara con el nombre de 
	//todos los conectados separados por /. Además primero nos dara el numero 
	//de conectados
	sprintf(conectados,"%d",lista->num);
	int i;
	for (i=0; i<lista->num; i++)
		sprintf(conectados, "%s/%s",conectados, lista->conectados[i].nombre);
}

//------------------------------------------------------------------------------
//Funcion atender cliente:
void *AtenderCliente (void *socket){
	
	//Socket para la ListaConectados
	miLista.num=0;
	int sock_conn;
	int *s;
	s=(int *) socket;
	sock_conn = *s;
	
	
	//Aqui recogermos la peticion del usuario y la respuesta del servidor
	char peticion[1024];
	char respuesta[1024];
	char conectado[200];
	int contadorSocket=0;
	int ret;
	
	//Establecemos la conexion con nuestro servidor
	conn = mysql_init(NULL);
	if (conn==NULL)
	{
		
		printf ("Error al crear la conexion: %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	conn = mysql_real_connect (conn, "localhost","root", "mysql",
							   "Juego",0, NULL, 0);
	
	if (conn==NULL)
	{
		
		printf ("Error al inicializar la conexion: %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	int terminar =0;
	//Abrimos un bucle que atendera a todas las peticiones que entren de un 
	//determinado cliente hasta que este se desconecte
	while(terminar==0){
		//Variables que usaremos en nuestro while
		int codigo;
		char nombre[20];
		char contrasena[20];
		int partidas_ganadas;
		char consulta[80];
		
		// Ahora recibimos su peticion
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf ("Recibido\n");
		
		// Tenemos que añadirle la marca de fin de string 
		// para que no escriba lo que hay despues en el buffer
		peticion[ret]='\0';
		
		//Escribimos el nombre en la consola para comprobar el mensaje recibido
		printf ("Se ha conectado: %s\n",peticion);
		
		//Recogemos el codigo obtenido
		char *p = strtok( peticion, "/"); 
		// Troceamos el mensaje adquirido dividiendo entre funcion y datos
		codigo =  atoi (p); 
		  
		//Comprobacion del codigo obtenido
		printf ("Codigo: %d \n",codigo);
		
		if (codigo==0){
			//Funcion de desconecion
			printf("Cierre \n");
			sprintf(respuesta,"Adios");
			terminar=1;
			
		}
		else 
		
			
		
			if (codigo == 1) {
				// Conectarse con un usuario registrado
				p = strtok( NULL, "/");
				
				//Obtenemos el nombre y la contraseña
				strcpy (nombre, p);
				p=strtok(NULL,"/");
				strcpy(contrasena,p);
				printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
				printf("%s %s \n",nombre, contrasena);
				
				//Establecemos la busqueda
				sprintf(peticion, "SELECT id FROM Jugador WHERE usuario= '%s' AND contrasena='%s';", nombre,contrasena);
				//escribimos en el buffer respuestra la longitud del nombre
				err=mysql_query (conn, peticion);
				resultado=mysql_store_result(conn);
				row = mysql_fetch_row(resultado);
				
				printf("1\n");
				if (err!=0)
				{
					printf ("Error al consultar datos de la base %u %s \n",
							mysql_errno(conn), mysql_error(conn));
					sprintf(respuesta,"Vaya un error se ha producido1");
				}
				else{
					sprintf(respuesta,"Bien venido %s",nombre);
				}
				printf("2\n");
				
			}
			printf("3\n");
			if(codigo == 2){
				//Crear nuevo ususario
				p = strtok( NULL, "/");
				
				//Obentenmos su nombre y contrasenya
				strcpy (nombre, p);
				p=strtok(NULL,"/");
				strcpy(contrasena,p);
				printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
				
				printf("%s %s \n",nombre, contrasena);
				
				//Añadimos la funcion que queremos que haga
				sprintf(peticion, "INSERT INTO Jugador(id, usuario, contrasena, email, partidas_ganadas, partidas_jugadas, conectado) VALUES ('%s', '%s', 'correo@gmail.com', 2, 3, 1);", nombre,contrasena);
				//escribimos en el buffer respuestra la longitud del nombre
				
				err=mysql_query (conn, peticion);
				//resultado = mysql_store_result(conn);
				
				sprintf(peticion, "SELECT usuario From Jugador;");
				err=mysql_query (conn, peticion);
				resultado = mysql_store_result(conn);
				
				printf("Resultado: %s \n", resultado);
				row=mysql_fetch_row(resultado);
				
				
				
				if (err!=0)
				{
					printf ("Error al consultar datos de la base %u %s \n",
							mysql_errno(conn), mysql_error(conn));
					sprintf(respuesta,"Vaya un error se ha producido un error \n");
				}
				else{
					sprintf(respuesta,"Bien venido al club %s",nombre);
				}
				printf("Hola2\n");
			}
			if(codigo == 3){
				//Buscamos si un usuario esta conectado
				p = strtok( NULL, "/");
				strcpy (nombre, p);
				printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
				printf("%s\n",nombre);
				printf("a\n");
				sprintf(peticion, "SELECT Conectat FROM Jugadors WHERE Usuari= '%s';", nombre);
				
				err=mysql_query (conn, peticion);
				printf("%d\n",err);
				printf("prueba\n");
				printf("%s\n",nombre);
				if (err!=0)
				{
					printf ("Error al consultar datos de la base %u %s \n",
							mysql_errno(conn), mysql_error(conn));
					sprintf(respuesta,"Vaya un error se ha producido un error");
					printf("b\n");
				}
				else {
					char respuesta[512]; 
					printf("%s\n",nombre);
					resultado = mysql_store_result (conn);
					
					row = mysql_fetch_row (resultado);
					
					int consulta1 = atoi(row[0]);
					printf("%d\n",consulta1);
					printf("c\n");
					
					printf("%s\n",nombre);
					
					if (row == NULL)
						printf ("No se han obtenido datos en la consulta\n");
					
					else{
						printf("d\n");
						printf("%s\n",nombre);
						if (consulta1==1){
							printf("%s\n",nombre);
							sprintf(respuesta,"%s esta conectado",nombre);
						}
						if (consulta1==0)
							sprintf(respuesta,"%s no esta conectado",nombre);
						
						row = mysql_fetch_row (resultado);
						int consulta1 = atoi(row[0]);
						printf("e\n");	
					}
				}
			}
			
			if (codigo == 4)
			{ 
				strcpy(nombre,p);
				printf("Nombre: %s, Codigo: %d, Partidas Ganadas: %d \n",nombre, codigo, partidas_ganadas);
				sprintf(peticion,"SELECT Jugador.partidas_ganadas FROM Jugador WHERE Jugador.usuario ='%s' ",nombre);
				err=mysql_query(conn, peticion);
				if (err!=0){
					printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn),mysql_error(conn));
					exit(1);
				}
				resultado = mysql_store_result(conn);
				row = mysql_fetch_row(resultado);
				if (row == NULL)
				{
					printf("No se ha obtenido la consulta \n"); 
				}
				else
				{
					int ans = atoi(row[0]);
					printf("El usuario ha ganado %d partidas \n",ans);
					sprintf(respuesta,"%s",row[0]);
				}
			}
			
			if (codigo == 5)
			{
				char nombre1[20];
				printf("Numero de partidas jugadas por: ");
				scanf("%s", nombre1);
				char consulta[1000];
				strcpy(consulta, "SELECT count(*) FROM (Jugador, Participacion) WHERE (Jugador.usuario = 'nombre1') AND (Participacion.id_usuario = Jugador.id)");
				strcat(consulta, nombre1);
			}
			if (codigo == 8)
			{
				
				
				sprintf(consulta,"SELECT usuario FROM (Jugador) WHERE (Jugador.conectado=1)");
				printf(consulta);
				err=mysql_query(conn, consulta);
				if (err!=0){
					printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn),mysql_error(conn));
					exit(1);
				}
				resultado = mysql_store_result(conn);
				row = mysql_fetch_row(resultado);
				if (row == NULL)
				{
					printf("No se ha obtenido la consulta \n"); 
				}
				else
				{
					char listanombres [500];
					while (row != NULL){
						sprintf(listanombres,"%s%s/",row[0]);
						row = mysql_fetch_row(resultado);
					}
					printf(listanombres);
				}
				
				
				sprintf(conectado, "%d", miLista.num);
				int i;
				for(i=0; i<miLista.num; i++){
						if  (miLista.conectados[i].socket==1 && miLista.conectados[i].socket==2){
							printf("%s %s",conectado,miLista.conectados[i].socket);
							sprintf(conectado, "%d-%s-%s", miLista.conectados[i].socket, miLista.conectados[i].nombre, conectado);
						}
						sprintf(conectado, "%d-%s-%s", miLista.conectados[i].socket, miLista.conectados[i].nombre, conectado);
					}
					printf("%s\n",conectado);
					sprintf(respuesta,"%s",conectado);
				
			}
			if (codigo == 7){
				strcpy (nombre, p);
				printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
				sprintf(consulta,"SELECT Jugador.partidas_jugadas FROM Jugador WHERE Jugador.usuario = '%s'",nombre);
				printf("%s",consulta);
				err=mysql_query(conn, consulta);
				if (err!=0)
				{
					printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn),mysql_error(conn));
					exit(1);
				}
				//Recogemos el resultado de la consulta 
				resultado = mysql_store_result(conn);
				row = mysql_fetch_row(resultado);
				if (row == NULL)
				{
					printf("No se ha obtenido la consulta\n"); 
				}
				else
				{
					printf("Nombre: %s, Partidas jugadas: %s\n", nombre, row[0]);
					int Partidas_jugadas = atoi(row[0]);
					
					if(Partidas_jugadas==0)
					{
						printf("Ninguna partida jugada\n");
						sprintf(respuesta,"0/No se ha jugado ninguna partida\n");
					}
					if (Partidas_jugadas!=0)
					{
						sprintf (consulta, "SELECT Partida.tablero FROM (Partida,Jugador,Participacion) WHERE Jugador.usuario = '%s' AND Jugador.id=Participacion.id_jugador AND Participacion.id_partida=Partida.id",nombre); 
						err=mysql_query(conn, consulta);
						if (err!=0)
						{
							printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn),mysql_error(conn));
							exit(1);
						}
						//Recogemos el resultado de la consulta 
						resultado = mysql_store_result(conn);
						row = mysql_fetch_row(resultado);
						char tableros[200] = " ";
						if (row == NULL)
						{
							printf("No se ha obtenido la consulta \n"); 
						}
						else
						{
							while (row!=NULL)
							{
								printf("Tablero: %s \n",row[0]);
								sprintf(tableros,"%s , %s",tableros,row[0]);
								row = mysql_fetch_row(resultado);
							}
							
							sprintf(respuesta,"1/%s",tableros);
						}
					}
				}
			}
				
			
			if (codigo == 9)
			{
				sprintf (respuesta,"%d",contador);
			}
			if (codigo != 0)
			{
				printf("Respuesta: %s \n", respuesta);
				// Enviamos la respuesta
				write (sock_conn,respuesta, strlen(respuesta));
			}
			printf("4\n");
			
			if ((codigo==1)||(codigo==2)|| (codigo==3)||(codigo==4)|| (codigo==5)|| (codigo==8)|| (codigo==7))
			{
				pthread_mutex_lock(&mutex);//no interrumpas
				contador = contador +1;
				pthread_mutex_unlock(&mutex);//puedes interrumpirme
			}
			
	printf("6\n");
	// Se acabo el servicio para este cliente
	close(sock_conn); 
	}
}

int main(int argc, char *argv[])
{
	//Variables
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0) {
		//socket en el que el servidor espera un pedido
		printf("Error creant socket \n");
		// Hacemos el bind al puerto
	}
	
	memset(&serv_adr, 0, sizeof(serv_adr));
	// inicialitza a zero serv_addr
	
	serv_adr.sin_family = AF_INET;
	//asocio el socket con la ip de la maquina que lo ha generado
	
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY); //INADDR_ANY configura siempre 
	//la ip asignada
	
	
	// escucharemos en el port 9050 este port puede variar en funcion del pc que
	//haga de srvidor
	serv_adr.sin_port = htons(9100); // indicamos el puerto
	
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind \n");
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 2) < 0) 
		// indicamos que es sock pasivo, el dos marca el numero de peticiones 
		//maximas en cola
		printf("Error en el Listen \n");
	
	int i=0;
	int sockets[100];
	pthread_t thread;
	
	for(;;){
		
		printf ("Escuchando\n"); //No ayuda a saber si hemos empezado a escuchar
		
		sock_conn = accept(sock_listen, NULL, NULL);
		//este sock se comunica con el programa con el que hemos conectado
		
		printf ("He recibido conexion\n"); //comprovamos si todo en orden
		//sock_conn es el socket que usaremos para este cliente
		//Bucle de atencion al cliente
		
		sockets[i]=sock_conn;
		
		pthread_create (&thread,NULL,AtenderCliente,&sockets[i]);
		
		i++;
	}
}
