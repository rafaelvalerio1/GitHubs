using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Biblioteca
using System.IO;

namespace ListaDrivers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //Lista
            List<string> lista = new List<string>();
            DriveInfo[] alldrivers = DriveInfo.GetDrives();

            //item.DriveType.ToString() == "Removable"
            foreach (DriveInfo item in alldrivers)
            {
                lista.Add($"Nome: {item}");
                lista.Add($"Volume: {item.DriveType.ToString()}");
                
                if(item.IsReady == true)
                {
                    lista.Add($"Volume label: {item.VolumeLabel}");
                    lista.Add($"Sistema de arquivos: {item.DriveFormat}");
                    lista.Add($"Espaço em disco para o usuário atual: {item.AvailableFreeSpace}");
                    lista.Add($"Total espaço dísponível: {item.TotalFreeSpace}");
                    lista.Add($"Tamanho total do drive: {item.TotalSize}");
                }
            }
            foreach(var ls in lista)
            {
                lbxLista.Items.Add(ls);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


