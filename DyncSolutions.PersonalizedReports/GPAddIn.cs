using Microsoft.Dexterity.Applications;
using Microsoft.Dexterity.Bridge;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Windows.Forms;

namespace DyncSolutions.PersonalizedReports
{
    public class GPAddIn : IDexterityAddIn
    {
        DYREP10100 ReportHeader;
        public void Initialize() { Dynamics.Forms.SyCustomReports.AddMenuHandler(DYREP10100, "Generador de  reportes"); }
        void DYREP10100(object sender, EventArgs e)
        {
            try
            {
                if (ReportHeader == null)
                    ReportHeader = new DYREP10100();
                else if (!ReportHeader.Created)
                    ReportHeader = new DYREP10100();
                ReportHeader.Activate();
                ReportHeader.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static bool ValidarCaracter(string strValidacion, char Caracter, string strCampo = "", int intTipo = 0)
        {
            bool flag = true;
            string str = "";
            switch (strValidacion)
            {
                case "[N1]":
                    str = "[N] 1234567890.";
                    break;
                case "[N2]":
                    str = "[N] 1234567890";
                    break;
                case "[A0]":
                    str = "[A] ";
                    break;
                case "[A1]":
                    str = "[A] '`!~^*; ";
                    break;
                case "[A2]":
                    str = "[A] '`!~^*;";
                    break;
                case "[A3]":
                    str = "[A] 1234567890()-. ";
                    break;
                case "[A4]":
                    str = "[A] '`";
                    break;
            }
            if (Strings.Asc(Caracter.ToString()) == 8)
                return false;
            if (intTipo == 1)
                return (Strings.InStr(5, str, Caracter.ToString(), CompareMethod.Binary) == 0) | ((Strings.Left(str, 3) == "[N]") & (Conversions.ToString(Caracter) == ".") & (Strings.InStr(1, strCampo, ".", CompareMethod.Binary) > 0));
            if (intTipo != 0)
                return flag;
            return (Strings.InStr(5, str, Caracter.ToString(), CompareMethod.Binary) > 0) | ((Strings.Left(str, 3) == "[N]") & (Conversions.ToString(Caracter) == ".") & (Strings.InStr(1, strCampo, ".", CompareMethod.Binary) > 0));
        }
    }
}