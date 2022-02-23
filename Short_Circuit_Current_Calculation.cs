using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchUploadConverter
{
    public partial class Short_Circuit_Current_Calculation : Form
    {
        double kva;
        double el;
        double z;
        double l;
        double i;
        double c;
        double r;
        public Short_Circuit_Current_Calculation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                kva = double.Parse(txt_KVA.Text);
                el = double.Parse(txt_E.Text);
                z = double.Parse(txt_Z.Text);
                l = double.Parse(txt_ft.Text);
                i = double.Parse(txt_I.Text);
                c = double.Parse(txt_C.Text);
                r = double.Parse(txt_R.Text);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           

            //First 
            double Ifl = Math.Round((kva * 1000) / el,2);
            lbl_transformerfla.Text = "Ifl = " + Ifl.ToString("N2");

            //Second
            double Tmultiplier = Math.Round(100 / z,2);
            lbl_transformerMultiplier.Text = "M =" + Tmultiplier.ToString("N2");

            //Third
            double CurrentSS = Math.Round(Ifl * Tmultiplier,2);
            lbl_currentShortCircuit.Text = "Isc = " + CurrentSS.ToString("N2");

            //Fourth
            double factorSinglePhase = Math.Round(Math.Round((2 * l * CurrentSS),2) /(c * el),3);
            lbl_factorsinglephase.Text = "f =" + factorSinglePhase.ToString("N3");

            //Fifth
            double multiplierfactor = Math.Round(1 / (1 + factorSinglePhase),3);
            lbl_multiplier_factor.Text = "m =" + multiplierfactor.ToString("N3");

            //Sixth
            double availableSym_ss = Math.Round(CurrentSS * multiplierfactor,2);
            lbl_ssfault.Text = "Isc @ Fault = " + availableSym_ss.ToString("N2");


            double approx = (Math.Floor(availableSym_ss / 1000) * 1000 ) + 1000;
            lbl_approx.Text = approx.ToString();

            double voltageDrop = Math.Round(Math.Round((2 * r * l * i),2) / 1000,2);
            lbl_voltagedrop.Text = "Vdrop = " + voltageDrop.ToString();

            double voltagedropPer = (voltageDrop / el) * 100;
            lbl_voltagedropper.Text = "Vdrop % = " + voltagedropPer.ToString("N2") + "%";

        }

        private void txt_mm_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                double meter = double.Parse(txt_mm.Text);
                double feet = meter * 3.28;
                txt_ft.Text = feet.ToString();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void Short_Circuit_Current_Calculation_Load(object sender, EventArgs e)
        {
            cbo_sm.Text = "Regular";
        }

        private void txt_mm_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double meter = double.Parse(txt_mm.Text);
                double feet = meter * 3.28;
                txt_ft.Text = feet.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cbo_sm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_sm.Text == "Residential")
            {
                txt_KVA.Text = "100";
            }
            else {
                txt_KVA.Text = "2500";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
