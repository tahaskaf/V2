using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using Microsoft.Win32;

namespace WindowsFormsApplication1
{
    public partial class Consulta3 : Form
    {
        Socket server;
        public Consulta3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse(IP.Text);
            IPEndPoint ipep = new IPEndPoint(direc, 9100);
            

            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); 
            // ProtocolType.Tcp nos indica el tipo de conexion cliente-servidor con la que trabajermos
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                this.BackColor = Color.Green;
                MessageBox.Show("Conectado");

            }
            catch (SocketException ex)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }

        }

        private void CierreServidor_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            string mensaje = "0/";
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);



            // Se terminó el servicio. 
            // Nos desconectamos
            
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Consulta2.Checked)
            {
                string mensaje = "5/" + NombreConsulta.Text;
                // Enviamos al servidor el nombre del usuario
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show(NombreConsulta.Text + " tuvo  " + mensaje + " victorias");
            }
            if (Conectado.Checked)
            {
                string mensaje = "3/" + Usuario_txt.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split(',')[0];
                MessageBox.Show(mensaje);

            }

            if (Consulta_3.Checked)
            {
                string mensaje = "6/" + NombreConsulta.Text;
                // Enviamos al servidor el nombre del usuario
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];

                string[] words = mensaje.Split('/');
                Int32.TryParse(words[0], out int numVal);
                if (numVal == 0)
                {
                    MessageBox.Show(words[1]);
                }
                else
                {
                    MessageBox.Show(NombreConsulta + " uso los siguientes tableros: " + words[1]);
                }


            }

            


        }

        private void Longitud_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CierreServidor_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            string mensaje = "0/";
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);



            // Se terminó el servicio. 
            // Nos desconectamos

            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }

        private void Jugar_Click(object sender, EventArgs e)
        {
            Form partida = new Form2();
            partida.Show();
        }

        private void Normas_Click(object sender, EventArgs e)
        {
            Form normas = new Normas();
            normas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse(IP.Text);
            IPEndPoint ipep = new IPEndPoint(direc, 9100);


            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // ProtocolType.Tcp nos indica el tipo de conexion cliente-servidor con la que trabajermos
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                this.BackColor = Color.Green;
                //MessageBox.Show("Conectado");

                try
                {
                    string mensaje = "1/" + Usuario_txt.Text + "/" + Contra_txt.Text;
                    MessageBox.Show(mensaje);
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    //Recibimos la respuesta del servidor
                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split(',')[0];
                    MessageBox.Show(mensaje);
                }
                catch
                {
                    MessageBox.Show("Vaya parece que ha habido un error");
                }

            }
            catch (SocketException ex)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }

        
    }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            //Movemos al frente el el icono de ocultar
            Ocultar.BringToFront();
            //Mostramos la contraseña
            Contra_txt.PasswordChar = '\0';
        }

        private void Ocultar_Click(object sender, EventArgs e)
        {
            //Movemos al frente el el icono de mostrar
            Mostrar.BringToFront();
            //Ocultamos la contraseña
            Contra_txt.PasswordChar = '*';
        }

        

        private void Mostar_2_Click(object sender, EventArgs e)
        {
                //Movemos al frente el el icono de ocultar
                Ocultar_2.BringToFront();
                //Mostramos la contraseña
                Contra_Reg.PasswordChar = '\0';
        }

        private void Ocultar_2_Click(object sender, EventArgs e)
        {
            
                //Movemos al frente el el icono de mostrar
                Mostar_2.BringToFront();
                //Ocultamos la contraseña
                Contra_Reg.PasswordChar = '*';
            

        }

        private void IP_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Register.Visible = true;
        }

        private void Registro_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse(IP.Text);
            IPEndPoint ipep = new IPEndPoint(direc, 9100);


            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // ProtocolType.Tcp nos indica el tipo de conexion cliente-servidor con la que trabajermos
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                this.BackColor = Color.Green;
                //MessageBox.Show("Conectado");

                try
                {
                    string mensaje = "2/" + Usuario_Reg.Text + "/" + Contra_Reg.Text;
                    MessageBox.Show(mensaje);
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    //Recibimos la respuesta del servidor
                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split(',')[0];
                    MessageBox.Show(mensaje);
                }
                catch
                {
                    MessageBox.Show("Vaya parece que ha habido un error");
                }
                Register.Visible = false;
                log_in.Visible = true;
                
            }
            catch (SocketException ex)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }
        }

        private void Servicios_Click(object sender, EventArgs e)
        {
            //Pedir numero de servicios realizados
            string mensaje = "4/";

            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            contLbl.Text = mensaje;
        }

        private void ListaConectados_Click(object sender, EventArgs e)
        {
            // Enviamos al servidor el nombre del usuario
            string mensaje = "7/" + Usuario_txt.Text + "/" + Contra_txt.Text;
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            //MessageBox.Show(mensaje);
            ListaConectados1.Rows.Clear();
            //Del servidor obtenemos un resultado: "jugadoresConectados.socket/listaConectados". Separaremos el resultado segun "." y insertaremos el resultado en words[]
            string[] words = mensaje.Split('.');
            Int32.TryParse(words[0], out int numVal);
            int existeConectado = 0;
            ListaConectados1.ColumnCount = 1;
            //this.ListaConectadosDG.Rows.Add();
            int cont = 1;
            while (numVal > 1 && existeConectado < numVal)
            {
                //string[] S = words[1].Split('/');
                //this.ListaConectadosDG.Rows.Add();
                ListaConectados1.Rows.Add(words[cont]);


                existeConectado++;
                cont++;
            }
            if (numVal == 1)
            {
                ListaConectados1.Rows.Add(words[1]);
            }
            if (numVal < 1)
            {
                ListaConectados1.Rows.Clear();
            }
        }
    }
}
