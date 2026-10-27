using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double score))
            {
                label1.Text = "შეიყვანე სწორი ქულა!";
            }
            else if (score < 0 || score > 100)
            {
                label1.Text = "ქულა უნდა იყოს 0-დან 100-მდე!";
            }
            else if (score >= 91)
            {
                label1.Text = "შეფასება: A";
            }
            else if (score >= 81)
            {
                label1.Text = "შეფასება: B";
            }
            else if (score >= 71)
            {
                label1.Text = "შეფასება: C";
            }
            else if (score >= 61)
            {
                label1.Text = "შეფასება: D";
            }
            else if (score >= 51)
            {
                label1.Text = "შეფასება: E";
            }
            else
            {
                label1.Text = "სტუდენტი ჩაიჭრა!";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textBox2.Text, out decimal price))
            {
                label3.Text = "შეიყვანე სწორი თანხა!";
            }
            else if (price <= 0)
            {
                label3.Text = "თანხა უნდა იყოს დადებითი!";
            }
            else if (comboBox1.SelectedItem == null)
            {
                label3.Text = "აირჩიე მომხმარებლის ტიპი!";
            }
            else
            {
                decimal discountRate;

                if (price >= 1000)
                    discountRate = 0.15m;
                else if (price >= 500)
                    discountRate = 0.10m;
                else if (price >= 200)
                    discountRate = 0.05m;
                else
                    discountRate = 0m;

                string customer = comboBox1.SelectedItem.ToString();

                if (customer == "VIP")
                    discountRate += 0.05m;
                else if (customer == "PREMIUM")
                    discountRate += 0.05m;

                decimal discount = price * discountRate;
                decimal finalPrice = price - discount;

                label3.Text =
                    $"ფასდაკლება: {discount:F2} ₾\nსაბოლოო ფასი: {finalPrice:F2} ₾";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox3.Text, out int age))
            {
                label5.Text = "შეიყვანე სწორი ასაკი!";
            }
            else if (age < 0)
            {
                label5.Text = "ასაკი არ შეიძლება იყოს უარყოფითი!";
            }
            else if (age < 18)
            {
                label5.Text = "ასაკი უნდა იყოს 18 ან უფრო მეტი!";
            }
            else if (comboBox2.SelectedItem == null)
            {
                label5.Text = "აირჩიე სეანსი!";
            }
            else
            {
                decimal price;

                if (age < 6)
                    price = 0;
                else if (age <= 17)
                    price = 10;
                else
                    price = 20;

                if (comboBox2.SelectedItem.ToString() == "დილის სეანსი")
                    price *= 0.80m;

                if (checkBox1.Checked)
                    price *= 0.90m;

                label5.Text = $"ბილეთის ფასი: {price:F2} ₾";
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            string password = textBox4.Text;
            textBox4.UseSystemPasswordChar = true;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
            }

            bool hasLetter = false;
            bool hasDigit = false;
            bool hasSpecial = false;

            foreach (char c in password)
            {
                if (char.IsLetter(c))
                    hasLetter = true;
                else if (char.IsDigit(c))
                    hasDigit = true;
                else
                    hasSpecial = true;
            }

            if (password.Length == 0)
            {
                label8.Text = "";
            }
            else if (password.Length < 8)
            {
                label8.Text = "სუსტი პაროლი!";
            }
            else if (hasLetter && hasDigit && hasSpecial)
            {
                label8.Text = "ძლიერი პაროლი!";
            }
            else if (hasLetter && hasDigit)
            {
                label8.Text = "კარგი პაროლი!";
            }
            else if (hasLetter)
            {
                label8.Text = "საშუალო პაროლი!";
            }
            else
            {
                label8.Text = "გამოიყენე ასოები და ციფრები!";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                if (!double.TryParse(textBox5.Text, out double a) ||
                    !double.TryParse(textBox6.Text, out double b) ||
                    !double.TryParse(textBox7.Text, out double c))
                {
                    label9.Text = "შეიყვანე სამივე გვერდი!";
                }
                else if (a <= 0 || b <= 0 || c <= 0)
                {
                    label9.Text = "გვერდები უნდა იყოს დადებითი!";
                }
                else if (a + b <= c || a + c <= b || b + c <= a)
                {
                    label9.Text = "ასეთი სამკუთხედი არ არსებობს!";
                }
                else if (a == b && b == c)
                {
                    label9.Text =
                        $"ტოლგვერდა სამკუთხედი. პერიმეტრი: {a + b + c}";
                }
                else if (a == b || a == c || b == c)
                {
                    label9.Text =
                        $"ტოლფერდა სამკუთხედი. პერიმეტრი: {a + b + c}";
                }
                else
                {
                    label9.Text =
                        $"სხვადასხვაგვერდა სამკუთხედი. პერიმეტრი: {a + b + c}";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox8.Text, out double kwh))
            {
                label10.Text = "შეიყვანე სწორი მოხმარება!";
            }
            else if (kwh < 0)
            {
                label10 .Text = "მოხმარება არ შეიძლება იყოს უარყოფითი!";
            }
            else
            {
                double bill;

                if (kwh <= 100)
                    bill = kwh * 0.15;
                else if (kwh <= 200)
                    bill = 100 * 0.15 + (kwh - 100) * 0.20;
                else
                    bill = 100 * 0.15 + 100 * 0.20 + (kwh - 200) * 0.25;

                label10.Text = $"გადასახადი: {bill:F2} ₾";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == null)
            {
                label11.Text = "აირჩიე აბონემენტის ტიპი!";
            }
            else if (comboBox4.SelectedItem == null)
            {
                label11.Text = "აირჩიე ხანგრძლივობა!";
            }
            else
            {
                string type = comboBox3.SelectedItem.ToString();
                decimal monthlyPrice;

                if (type == "Basic")
                    monthlyPrice = 50;
                else if (type == "Standard")
                    monthlyPrice = 80;
                else
                    monthlyPrice = 120;

                int months;
                decimal discountRate;

                if (comboBox4.SelectedIndex == 0)
                {
                    months = 1;
                    discountRate = 0m;
                }
                else if (comboBox4.SelectedIndex == 1)
                {
                    months = 3;
                    discountRate = 0.10m;
                }
                else
                {
                    months = 12;
                    discountRate = 0.20m;
                }

                decimal total = monthlyPrice * months * (1 - discountRate);

                label11.Text = $"სრული ღირებულება: {total:F2} ₾";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox9.Text, out double temperature))
            {
                label12.Text = "შეიყვანე სწორი ტემპერატურა!";
            }
            else if (comboBox5.SelectedItem == null)
            {
                label12.Text = "აირჩიე ამინდის მდგომარეობა!";
            }
            else
            {
                string recommendation;

                if (temperature < 0)
                    recommendation = "ჩაიცვი თბილად.";
                else if (temperature <= 15)
                    recommendation = "ჩაიცვი ქურთუკი.";
                else if (temperature <= 25)
                    recommendation = "სასიამოვნო ამინდია.";
                else
                    recommendation = "მოერიდე მზეზე დიდხანს ყოფნას.";

                if (comboBox5.SelectedItem.ToString() == "წვიმიანი")
                    recommendation += "\nთან იქონიე ქოლგა.";

                label12.Text = recommendation;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox10.Text, out int hours))
            {
                label13.Text = "შეიყვანე სწორი საათების რაოდენობა!";
            }
            else if (hours <= 0)
            {
                label13.Text = "საათების რაოდენობა უნდა იყოს დადებითი!";
            }
            else if (comboBox6.SelectedItem == null)
            {
                label13.Text = "აირჩიე ავტომობილის ტიპი!";
            }
            else
            {
                decimal fee = 2 + (hours - 1) * 1;

                if (comboBox6.SelectedItem.ToString() == "დიდი ავტომობილი")
                    fee *= 1.5m;

                if (hours > 8)
                    fee += 5;

                label13.Text = $"გადასახდელი თანხა: {fee:F2} ₾";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textBox11.Text, out decimal income) ||
                !decimal.TryParse(textBox12.Text, out decimal obligations) ||
                !decimal.TryParse(textBox13.Text, out decimal payment))
            {
                label14.Text = "შეიყვანე სამივე მნიშვნელობა სწორად!";
            }
            else if (income <= 0)
            {
                label14.Text = "შემოსავალი უნდა იყოს დადებითი!";
            }
            else if (obligations < 0 || payment < 0)
            {
                label14.Text = "ვალდებულებები და გადასახადი არ შეიძლება იყოს უარყოფითი!";
            }
            else
            {
                decimal total = obligations + payment;
                decimal percent = total / income * 100;

                if (total > income * 0.40m)
                    label14.Text = $"მაღალი დატვირთვა ({percent:F1}%)";
                else
                    label14.Text = $"მისაღები დატვირთვა ({percent:F1}%)";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox14.Text, out double distance))
            {
                label15.Text = "შეიყვანე სწორი მანძილი!";
            }
            else if (distance <= 0)
            {
                label15.Text = "მანძილი უნდა იყოს დადებითი!";
            }
            else if (comboBox7.SelectedItem == null)
            {
                label15.Text = "აირჩიე ტაქსის კლასი!";
            }
            else
            {
                string taxiClass = comboBox7.SelectedItem.ToString();
                double rate;

                if (taxiClass == "Economy")
                    rate = 1.2;
                else if (taxiClass == "Comfort")
                    rate = 1.8;
                else
                    rate = 2.5;

                double price = distance * rate;

                if (price < 4)
                    price = 4;

                if (checkBox2.Checked)
                    price *= 1.25;

                label15.Text = $"საბოლოო ფასი: {price:F2} ₾";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox15.Text, out int stock) ||
                !int.TryParse(textBox16.Text, out int requested))
            {
                label16.Text = "შეიყვანე ორივე რაოდენობა სწორად!";
            }
            else if (stock < 0 || requested < 0)
            {
                label16.Text = "რაოდენობა არ შეიძლება იყოს უარყოფითი!";
            }
            else
            {
                string status;

                if (stock == 0)
                    status = "პროდუქტი ამოწურულია.";
                else if (stock <= 5)
                    status = "კრიტიკულად დაბალი მარაგი.";
                else if (stock <= 20)
                    status = "მარაგი იკლებს.";
                else
                    status = "საკმარისი მარაგი.";

                if (requested > stock)
                    status += "\nშეკვეთის შესრულება შეუძლებელია!";

                label16.Text = status;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox17.Text, out int age))
            {
                label17.Text = "შეიყვანე სწორი ასაკი!";
            }
            else if (!double.TryParse(textBox18.Text, out double score))
            {
                label17.Text = "შეიყვანე სწორი ქულა!";
            }
            else if (comboBox8.SelectedItem == null)
            {
                label17.Text = "აირჩიე გამოცდის ტიპი!";
            }
            else if (age < 16)
            {
                label17.Text = "ასაკი უნდა იყოს მინიმუმ 16 წელი!";
            }
            else if (score < 0 || score > 100)
            {
                label17.Text = "ქულა უნდა იყოს 0-დან 100-მდე!";
            }
            else if (comboBox8.SelectedItem.ToString() == "Advanced" && score < 70)
            {
                label17.Text = "Advanced გამოცდისთვის ქულა უნდა იყოს მინიმუმ 70!";
            }
            else
            {
                label17.Text = "რეგისტრაცია შესაძლებელია!";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (comboBox9.SelectedItem == null)
            {
                label18.Text = "აირჩიე კერძი!";
            }
            else if (!int.TryParse(textBox19.Text, out int quantity))
            {
                label18.Text = "შეიყვანე სწორი რაოდენობა!";
            }
            else if (quantity <= 0)
            {
                label18.Text = "რაოდენობა უნდა იყოს დადებითი!";
            }
            else
            {
                string dish = comboBox9.SelectedItem.ToString();
                decimal unitPrice;

                if (dish == "ბურგერი")
                    unitPrice = 12;
                else if (dish == "პიცა")
                    unitPrice = 20;
                else
                    unitPrice = 8;

                decimal total = unitPrice * quantity;

                if (radioButton2.Checked && total <= 50)
                    total += 5;

                label18.Text = $"საბოლოო თანხა: {total:F2} ₾";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            label3.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            checkBox1.Checked = false;
            comboBox2.SelectedIndex = -1;
            label5.Text = "ასაკი";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            label8.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            label9.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
            label10.Text = "";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            label11.Text = "";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox9.Clear();
            comboBox5.SelectedIndex = -1;
            label12.Text = "";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
            comboBox6.SelectedIndex = -1;
            label13.Text = "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            label14.Text = "";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox14.Clear();
            comboBox7.SelectedIndex = -1;
            checkBox2.Checked = false;
            label15.Text = "";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox15.Clear();
            textBox16.Clear();
            label16.Text = "";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox17.Clear();
            textBox18.Clear();
            comboBox8.SelectedIndex = -1;
            label17.Text = "";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            comboBox9.SelectedIndex = -1;
            textBox19.Clear();
            radioButton1.Checked = true;
            label18.Text = "";
        }
    }
}