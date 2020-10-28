using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace DcExtension15
{
    public partial class frmDcExtension : Form
    {

        #region Atributos

        Image on = DcExtension15.Properties.Resources.ON;
        Image off = DcExtension15.Properties.Resources.OFF;

        Image Switch_Fifa15_On = DcExtension15.Properties.Resources.switch_fifa15_ON;
        Image Switch_Fifa15_Off = DcExtension15.Properties.Resources.switch_fifa15_OFF;
        Image Switch_Fifa15_intermedio = DcExtension15.Properties.Resources.switch_fifa15_intermedio;

        //obtengo el path del directorio donde se encuentra el .exe
        string DirectorioRaiz = Directory.GetCurrentDirectory();
        //nombre de la carpeta original del juego
        string DataORIGINAL = Directory.GetCurrentDirectory() + @"\data";
        string DlcORIGINAL = Directory.GetCurrentDirectory() + @"\dlc";
        //nombre de la carpeta DC Extension
        string DataDC =Directory.GetCurrentDirectory() + @"\data_dc";
        string DlcDC =Directory.GetCurrentDirectory() + @"\dlc_dc";
        //nombre de la carpeta backup de la original
        string DataBKP =Directory.GetCurrentDirectory() + @"\data_bkp";
        string DlcBKP =Directory.GetCurrentDirectory() + @"\dlc_bkp";
        
        bool DCEActivado = false;
        bool Regenerar = false;

        public class Constante
        {
            public const string ACTIVADO = "DCExtension ON";
            public const string DESACTIVADO = "DCExtension OFF";
        }
        #endregion

        #region Eventos

        public frmDcExtension()
        {

            InitializeComponent();

            CheckVersion();

            if (DCExtensionActivated())
            {
                DCEActivado = true;
                btnSwitch.Image = Switch_Fifa15_On;
                IconoDeNotificacionActivado();
            }
            else
            {
                DCEActivado = false;
                btnSwitch.Image = Switch_Fifa15_Off;
                IconoDeNotificacionDesactivado();
            }
            //Si existe la carpeta DATA_BKP es porque estaba activado de una instancia anterior
            //entonces lo desactivamos, salvo la primera vez:  
            if (DCExtensionActivated() && Regenerar)
                DesactivarDCExtension();
            else
                if(Regenerar)
                    ActivarDCExtension();

            Regenerar = true;
                        
        }
     
        private void frmDcExtension_Load(object sender, EventArgs e)
        {        
            ActivarWebBrowserDCNews();
        }

    

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            SwitchDCExtension();
        }

        private void activarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DCEActivado)
                MessageBox.Show("Death Command Extension already set.");
            else
                SwitchDCExtension();
        }

        private void desactivarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DCEActivado)
                MessageBox.Show("Death Command Extension already disabled.");
            else
                SwitchDCExtension();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void niIcono_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SwitchDCExtension();
        }

        private void btnSwitch_MouseHover(object sender, EventArgs e)
        {
            btnSwitch.Image = Switch_Fifa15_intermedio;
        }

        private void btnSwitch_MouseLeave(object sender, EventArgs e)
        {
            if (DCEActivado)
                btnSwitch.Image = Switch_Fifa15_On;
            else
                btnSwitch.Image = Switch_Fifa15_Off;
        }

        //click izquierdo en el icono de notificacion muestra el menu contextual.
        private void niIcono_Click(object sender, EventArgs e)
        {
            mnuContextual.Show(Cursor.Position);
        }
        #endregion



        #region Metodos

        bool DCExtensionActivated()
        {
            return Directory.Exists(DataBKP);
        }

        private void CheckVersion()
        {
            if (File.Exists(DirectorioRaiz + @"\dcVersion.txt"))
            {
                System.IO.StreamReader file = new System.IO.StreamReader(DirectorioRaiz + @"\dcVersion.txt");
                string line;
                line = file.ReadLine();
                lblNumberOfVersion.Text = line;
            }
            else
            {
                lblNumberOfVersion.Text = "UNKNOWN";
            }

        }
        private void ActivarDCExtension()
        {           
            IntercambioDirectoriosADC();
            DCEActivado = true;
            btnSwitch.Image = Switch_Fifa15_On;
            IconoDeNotificacionActivado();
            RegenerarArchivosSubProceso();           
        }

        private void IntercambioDirectoriosADC()
        {
            try
            {               
                System.IO.Directory.Move(DataORIGINAL, DataBKP);
                System.IO.Directory.Move(DlcORIGINAL, DlcBKP);

                System.IO.Directory.Move(DataDC, DataORIGINAL);
                System.IO.Directory.Move(DlcDC, DlcORIGINAL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }        
        }

        private void DesactivarDCExtension()
        {            
            IntercambioDirectoriosAOrig();
            DCEActivado = false;
            btnSwitch.Image = Switch_Fifa15_Off;
            IconoDeNotificacionDesactivado();
            RegenerarArchivosSubProceso();
           
        }

        private void RegenerarArchivosSubProceso()
        {
            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe");
            psi.Arguments = "/c \"regenerator.exe -key -care -all";
            p.StartInfo = psi;
            p.Start();
        }
        private void IntercambioDirectoriosAOrig()
        {
            try
            {

                System.IO.Directory.Move(DataORIGINAL, DataDC);
                System.IO.Directory.Move(DlcORIGINAL, DlcDC);

                System.IO.Directory.Move(DataBKP, DataORIGINAL);
                System.IO.Directory.Move(DlcBKP, DlcORIGINAL);

            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
                throw ex;
            }      
        }
        private void IconoDeNotificacionActivado()
        {
            niIcono.Icon = DcExtension15.Properties.Resources.ON_ico;
            niIcono.ContextMenuStrip = this.mnuContextual;
            niIcono.ShowBalloonTip(1, "ON", "Death Command extension has been activated", ToolTipIcon.Info);
            niIcono.Text = Constante.ACTIVADO;
        }     
             

        private void SwitchDCExtension()
        {
            if (DCEActivado)
            {
                DesactivarDCExtension();
            }
            else
            {
                ActivarDCExtension();
            }
        }

     

        private void IconoDeNotificacionDesactivado()
        {
            niIcono.Icon = DcExtension15.Properties.Resources.OFF_ico;
            niIcono.ContextMenuStrip = this.mnuContextual;
            niIcono.ShowBalloonTip(1, "OFF", "Death Command extension has been disabled", ToolTipIcon.Info);
            niIcono.Text = Constante.DESACTIVADO;
        }

        
        
        
        private void ActivarWebBrowserDCNews()
        {
            // seteo la direccion de las news y navego a la pagina.
            string urlNews = "http://www.deathcommand.com/latest-extension-fifa15_update/";
           
            wbDCNews.ScriptErrorsSuppressed = true;
            wbDCNews.Navigate(new Uri(urlNews));
        }




        #endregion





        #region NewsDCExtension   
        //para manejo de errores en la webBox (no lo estoy usando)
        //al final use esto: wbDCNews.ScriptErrorsSuppressed = true;


        // Hides script errors without hiding other dialog boxes.
        private void SuppressScriptErrorsOnly(WebBrowser browser)
        {
            // Ensure that ScriptErrorsSuppressed is set to false.
            browser.ScriptErrorsSuppressed = false;

            // Handle DocumentCompleted to gain access to the Document object.
            browser.DocumentCompleted +=
                new WebBrowserDocumentCompletedEventHandler(
                    browser_DocumentCompleted);
        }

        private void browser_DocumentCompleted(object sender,
            WebBrowserDocumentCompletedEventArgs e)
        {
            ((WebBrowser)sender).Document.Window.Error +=
                new HtmlElementErrorEventHandler(Window_Error);
        }

        private void Window_Error(object sender,
            HtmlElementErrorEventArgs e)
        {
            // Ignore the error and suppress the error dialog box. 
            e.Handled = true;
        }

        #endregion

        

    }
}
