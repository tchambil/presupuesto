using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public static class WinForm
    {
        public static void pfCleanTextBox(Form f_form)
        {


            foreach (Control control1 in f_form.Controls)
            {
                if (control1 is TextBox)
                    control1.Text = "";
                if (control1 is ComboBox)
                    control1.Text = "";
                foreach (Control control2 in control1.Controls)
                {
                    if (control2 is TextBox)
                        control2.Text = "";
                    if (control2 is ComboBox)
                        control2.Text = "";
                    foreach (Control control3 in control2.Controls)
                    {
                        if (control3 is TextBox)
                            control3.Text = "";
                        if (control3 is ComboBox)
                            control3.Text = "";
                        foreach (Control control4 in control3.Controls)
                        {
                            if (control4 is TextBox)
                                control4.Text = "";
                            if (control4 is ComboBox)
                                control4.Text = "";
                            foreach (Control control5 in control4.Controls)
                            {
                                if (control5 is TextBox)
                                    control5.Text = "";
                                if (control5 is ComboBox)
                                    control5.Text = "";
                                foreach (Control control6 in control5.Controls)
                                {
                                    if (control6 is TextBox)
                                        control6.Text = "";
                                    if (control6 is ComboBox)
                                        control6.Text = "";
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void pfActiveControl(Form f_form, bool b_Estate)
        {
            foreach (Control control1 in f_form.Controls)
            {
                if (control1 is TextBox)
                    control1.Enabled = b_Estate;
                if (control1 is ComboBox)
                    control1.Enabled = b_Estate;
                if (control1 is DateTimePicker)
                    control1.Enabled = b_Estate;
                if (control1 is DataGridView)
                    control1.Enabled = b_Estate;
                if (control1 is Button)
                    control1.Enabled = b_Estate;
                if (control1 is NumericUpDown)
                    control1.Enabled = b_Estate;
                if (control1 is MaskedTextBox)
                    control1.Enabled = b_Estate;

                foreach (Control control2 in control1.Controls)
                {
                    if (control2 is TextBox)
                        control2.Enabled = b_Estate;
                    if (control2 is ComboBox)
                        control2.Enabled = b_Estate;
                    if (control2 is DateTimePicker)
                        control2.Enabled = b_Estate;
                    if (control2 is DataGridView)
                        control2.Enabled = b_Estate;
                    if (control2 is Button)
                        control2.Enabled = b_Estate;
                    if (control2 is NumericUpDown)
                        control2.Enabled = b_Estate;
                    if (control2 is MaskedTextBox)
                        control2.Enabled = b_Estate;
                    foreach (Control control3 in control2.Controls)
                    {
                        if (control3 is TextBox)
                            control3.Enabled = b_Estate;
                        if (control3 is ComboBox)
                            control3.Enabled = b_Estate;
                        if (control3 is DateTimePicker)
                            control3.Enabled = b_Estate;
                        if (control3 is DataGridView)
                            control3.Enabled = b_Estate;
                        if (control3 is Button)
                            control3.Enabled = b_Estate;
                        if (control3 is NumericUpDown)
                            control3.Enabled = b_Estate;
                        if (control3 is MaskedTextBox)
                            control3.Enabled = b_Estate;
                        foreach (Control control4 in control3.Controls)
                        {
                            if (control4 is TextBox)
                                control4.Enabled = b_Estate;
                            if (control4 is ComboBox)
                                control4.Enabled = b_Estate;
                            if (control4 is DateTimePicker)
                                control4.Enabled = b_Estate;
                            if (control4 is DataGridView)
                                control4.Enabled = b_Estate;
                            if (control4 is Button)
                                control4.Enabled = b_Estate;
                            if (control4 is NumericUpDown)
                                control4.Enabled = b_Estate;
                            if (control4 is MaskedTextBox)
                                control4.Enabled = b_Estate;
                            foreach (Control control5 in control4.Controls)
                            {
                                if (control5 is TextBox)
                                    control5.Enabled = b_Estate;
                                if (control5 is ComboBox)
                                    control5.Enabled = b_Estate;
                                if (control5 is DateTimePicker)
                                    control5.Enabled = b_Estate;
                                if (control5 is DataGridView)
                                    control5.Enabled = b_Estate;
                                if (control5 is Button)
                                    control5.Enabled = b_Estate;
                                if (control5 is NumericUpDown)
                                    control5.Enabled = b_Estate;
                                if (control5 is MaskedTextBox)
                                    control5.Enabled = b_Estate;
                                foreach (Control control6 in control5.Controls)
                                {
                                    if (control6 is TextBox)
                                        control6.Enabled = b_Estate;
                                    if (control6 is ComboBox)
                                        control6.Enabled = b_Estate;
                                    if (control6 is DateTimePicker)
                                        control6.Enabled = b_Estate;
                                    if (control6 is DataGridView)
                                        control6.Enabled = b_Estate;
                                    if (control6 is Button)
                                        control6.Enabled = b_Estate;
                                    if (control6 is NumericUpDown)
                                        control6.Enabled = b_Estate;
                                    if (control6 is MaskedTextBox)
                                        control6.Enabled = b_Estate;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void pfActiveButon(Form f_form, bool b_Estate)
        {
            foreach (Control ctrl in f_form.Controls)
            {

                if (ctrl is Button)
                    ctrl.Enabled = b_Estate;
            }

            
        }





    }
}
