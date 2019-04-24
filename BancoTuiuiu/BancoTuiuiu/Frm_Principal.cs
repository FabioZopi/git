using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BancoTuiuiu
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //lista
            List<string> lista = new List<string>();

            // prove acesso a tds os drivers conectados na maquina
            DriveInfo[] alldrives = DriveInfo.GetDrives();

            foreach (DriveInfo item in alldrives)
            {
                lista.Add($"Nome: {item.Name}");
                lista.Add($"volume: {item.DriveType.ToString()}");

                if (item.IsReady == true)
                {
                    lista.Add($"volume label: {item.VolumeLabel}");
                    lista.Add($"sistema de arquivos: {item.DriveFormat}");
                    lista.Add($"espaço em disco para usuario atual: {item.AvailableFreeSpace}");
                    lista.Add($"total espaço disponivel: {item.TotalFreeSpace}");
                    lista.Add($"tamanho total do drive: {item.TotalSize}");
                    return;
                }

                else
                {


                }


            }

           
        }
    }
}
