using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Carco_App
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(comboBox.SelectedItem == "England")
            {
                this.pictureBox1.Image = global::Carco_App.Properties.Resources.flag_england_icon;
            }
            else if(comboBox.SelectedItem == "China")
            {
                this.pictureBox1.Image = global::Carco_App.Properties.Resources.flag_china_icon;
            }else if(comboBox.SelectedItem == "Turkey")
            {
                this.pictureBox1.Image = global::Carco_App.Properties.Resources.flag_turkey_icon;
            }
                
         
            
        }

        private void button_hesapla_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == "Quru Mehsul")
            {
                if (comboBox.SelectedItem == "England")
                {
                    England obj = new England();
                    obj.Set_ceki(Convert.ToDouble(ceki_box.Text));
                    obj.Set_mehsul("Quru Mehsul");
                    obj.Set_qiymet(Convert.ToDouble(malin_qiymeti_box.Text));
                    qiymet_box.Text = obj.hesaplama().ToString("0.##") + " AZN";
                }
                else if (comboBox.SelectedItem == "Turkey")
                {
                    Turkey obj = new Turkey();
                    obj.Set_ceki(Convert.ToDouble(ceki_box.Text));
                    obj.Set_mehsul("Quru Mehsul");
                    obj.Set_qiymet(Convert.ToDouble(malin_qiymeti_box.Text));
                    qiymet_box.Text = obj.hesaplama().ToString("0.##") + " AZN";
                }
                else if (comboBox.SelectedItem == "China")
                {
                    China obj = new China();
                    obj.Set_ceki(Convert.ToDouble(ceki_box.Text));
                    obj.Set_mehsul("Quru Mehsul");
                    obj.Set_qiymet(Convert.ToDouble(malin_qiymeti_box.Text));
                    qiymet_box.Text = obj.hesaplama().ToString("0.##") + " AZN";
                }
            }
            else if (comboBox2.SelectedItem == "Sulu Mehsul")
            {
                if (comboBox.SelectedItem == "England")
                {
                    England obj = new England();
                    obj.Set_ceki(Convert.ToDouble(ceki_box.Text));
                    obj.Set_mehsul("Sulu Mehsul");
                    obj.Set_qiymet(Convert.ToDouble(malin_qiymeti_box.Text));
                    qiymet_box.Text = obj.hesaplama().ToString("0.##") + " AZN";
                }
                else if (comboBox.SelectedItem == "Turkey")
                {
                    Turkey obj = new Turkey();
                    obj.Set_ceki(Convert.ToDouble(ceki_box.Text));
                    obj.Set_mehsul("Sulu Mehsul");
                    obj.Set_qiymet(Convert.ToDouble(malin_qiymeti_box.Text));
                    qiymet_box.Text = obj.hesaplama().ToString("0.##") + " AZN";
                }
                else if (comboBox.SelectedItem == "China")
                {
                    China obj = new China();
                    obj.Set_ceki(Convert.ToDouble(ceki_box.Text));
                    obj.Set_mehsul("Sulu Mehsul");
                    obj.Set_qiymet(Convert.ToDouble(malin_qiymeti_box.Text));
                    qiymet_box.Text = obj.hesaplama().ToString("0.##") + " AZN";
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }

    abstract class Country
    {
        public double ceki;
        public string mehsul;
        public double qiymet;

        public double Get_ceki()
        {
            return this.ceki;
        }
        public void Set_ceki(double ceki)
        {
            this.ceki = ceki;
        }

        public string Get_mehsul()
        {
            return this.mehsul;
        }
        public void Set_mehsul(string mehsul)
        {
            this.mehsul = mehsul;
        }

        public double Get_qiymet()
        {
            return this.qiymet;
        }
        public void Set_qiymet(double qiymet)
        {
            this.qiymet = qiymet;
        }


        public abstract double hesaplama();
        
    }

    class England : Country
    {
        
        public override double hesaplama()
        {
            

            if (mehsul == "Quru Mehsul")
            {
                if (ceki > 1000 && ceki <= 3500)
                {
                    return qiymet * 1.2;
                }
                else if (ceki > 3500 && ceki < 7500)
                {
                    return qiymet * 1.5;
                }
                else if (ceki >= 7500)
                {
                    return qiymet * 1.8;
                }
            }
            else if (mehsul == "Sulu Mehsul")
            {
                if (ceki > 1000 && ceki <= 3500)
                {
                    return qiymet * 1.3;
                }
                else if (ceki > 3500 && ceki < 7500)
                {
                    return qiymet * 1.6;
                }
                else if (ceki >= 7500)
                {
                    return qiymet * 1.9;
                }
            }

            return qiymet;
            
        }

        
    }

    class Turkey : Country
    {
        public override double hesaplama()
        {
            
            if (mehsul == "Quru Mehsul") {
                if (ceki > 1000 && ceki <= 3500)
                {
                    return qiymet * 1.4;
                }
                else if (ceki > 3500 && ceki < 7500)
                {
                    return qiymet * 1.8;
                }
                else if (ceki >= 7500)
                {
                    return qiymet * 2;
                }
            }
            else if(mehsul == "Sulu Mehsul")
            {
                if (ceki > 1000 && ceki <= 3500)
                {
                    return qiymet * 1.5;
                }
                else if (ceki > 3500 && ceki < 7500)
                {
                    return qiymet * 1.9;
                }
                else if (ceki >= 7500)
                {
                    return qiymet * 2.1;
                }
            }

            return qiymet;
        }
    }

    class China : Country
    {
        public override double hesaplama()
        {
            
            if (mehsul == "Quru Mehsul")
            {
                if (ceki > 1000 && ceki <= 3500)
                {
                    return qiymet * 1.1;
                }
                else if (ceki > 3500 && ceki < 7500)
                {
                    return qiymet * 1.3;
                }
                else if (ceki >= 7500)
                {
                    return qiymet * 1.6;
                }
            }
            else if (mehsul == "Sulu Mehsul")
            {
                if (ceki > 1000 && ceki <= 3500)
                {
                    return qiymet * 1.2;
                }
                else if (ceki > 3500 && ceki < 7500)
                {
                    return qiymet * 1.4;
                }
                else if (ceki >= 7500)
                {
                    return qiymet * 1.7;
                }
            }

                return qiymet;
        }
    }

    
}