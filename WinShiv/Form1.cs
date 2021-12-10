using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Net.Sockets;

namespace WinShiv
{
    public partial class Form1 : Form
    {
        internal static CngKey MyKeySignature;
        internal static byte[] MyPubKeyBlob;

        public Form1()
        {
            InitializeComponent();
        }
        //
        //Объявление общих элементов для нескольких методов.
        //
        byte[] MyData;
        byte[] MySignature;
        bool pas = false;
        bool pas0 = false;
        string Mypas = "0000";
        string[] password = new string[1] { "" };

        int Ihash = 0;
        string[] HASH = new string[100];
        string pasOK = "Пароль подтвержден";
        string pasNO = "Пароль не подтвержден";

        AesManaged aeskey = new AesManaged();
        byte[] MyKey;
        byte[] MyIV;

        byte[] Mypost;
        //
        //В методе Form1_Load при каждой загрузке формы создаетс ключ и вектор для 
        //симметричного шифрования, а также сообщается пользователю, как разблокировать программу.
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            password[0] = Processor.GetHashString(Mypas);

            aeskey.GenerateKey();
            aeskey.GenerateIV();
            MyKey = aeskey.Key;
            MyIV = aeskey.IV;

            this.textBox2.Visible = true;
            textBox2.Text = 
                "разблокируйте программу специальным заводским паролем '0000'" +
                "(функция проверить пароль) и установите свой";
        }
        //
        //В методе изменитьТекстToolStripMenuItem_Click отчищается форма.
        //
        private void изменитьТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox2.Visible = false;
            textBox1.Text = Console.ReadLine();
        }
        //
        //В методе добавитьпарольToolStripMenuItem_Click хешируется введенный пароль, после
        //он добавляется в массив паролей.
        //Данный метод доступен только администратору, если пользователь не имеет доступа,
        //программа выдаст ошибку и попросить пользователя подтвердить специальный пароль.
        //
        private void добавитьпарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pas0)
            {
                this.textBox2.Visible = false;
                HASH[Ihash] = Processor.GetHashString(textBox1.Text);
                Ihash++;
                textBox1.Text = Console.ReadLine();
            }
            else
            {
                this.textBox2.Visible = true;
                textBox2.Text = "подтвердите специальный пароль";
                textBox1.Text = "ошибка";
            }
        }
        //
        //В методе проверитьпарольToolStripMenuItem_Click хешируется текст элемента textBox1,
        //после чего в цикле в массиве хеша ищется идентичный введенному хеш. Если есть совпадения,
        //то дается подтверждение пароля и разблокируется программа(аналогично со специальном
        //паролем, только добавляются административные права).
        //В противном случае пользователю сообщается, что пароль не найден.
        //
        private void проверитьпарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Ok = false;
            this.textBox2.Visible = true;
            for (int i = 0; i < Ihash; i++)
            {
                if (Processor.GetHashString(textBox1.Text) == HASH[i])
                {
                    textBox2.Text = pasOK;
                    Ok = true;
                    pas = true;
                }
            }
            if (!Ok)
                textBox2.Text = pasNO;
            if (password[0] == Processor.GetHashString(textBox1.Text))
            {
                pas0 = true;
                pas = true;
                textBox2.Text = "специальный пароль подтвержден, административные права получены";
                textBox1.Text = Console.ReadLine();
            }
        }
        //
        //В методе удалитьПарольToolStripMenuItem_Click хешируется текст элемента textBox1,
        //после чего в цикле в массиве хеша ищется идентичный введенному хеш. Если есть совпадения,
        //то пароль удалется и выдается сообщение "пароль удален".
        //В противном случае пользователю сообщается, что пароль не найден.
        //Данный метод доступен только администратору, если пользователь не имеет доступа,
        //программа выдаст ошибку и попросить пользователя подтвердить специальный пароль.
        //
        private void удалитьПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (pas0)
            {
                bool Ok = false;
                this.textBox2.Visible = true;
                for (int i = 0; i < Ihash; i++)
                {
                    if (Processor.GetHashString(textBox1.Text) == HASH[i])
                    {
                        textBox2.Text = "пароль удален";
                        Ok = true;
                        HASH[i] = password[0];
                    }
                }
                if (!Ok)
                    textBox2.Text = "пароль не найден";
            }
            else
            {
                this.textBox2.Visible = true;
                textBox2.Text = "подтвердите пароль";
                textBox1.Text = "ошибка";
            }
        }
        //
        //В методе показатьХешToolStripMenuItem_Click хешируется текст элемента textBox1,
        //после чего в цикле в массиве хеша ищется идентичный введенному хеш. Если есть совпадения,
        //то выводится хеш пароля в textBox2.
        //В противном случае пользователю сообщается, что хеш не найден.
        //Данный метод становиться недоступным,после блокировки и до подтверждения пароля.
        //
        private void показатьХешToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pas)
            {
                bool Ok = false;
                this.textBox2.Visible = true;
                for (int i = 0; i < Ihash; i++)
                {
                    if (Processor.GetHashString(textBox1.Text) == HASH[i])
                    {
                        textBox2.Text = HASH[i];
                        Ok = true;
                    }
                }
                if (password[0] == Processor.GetHashString(textBox1.Text))
                {
                    pas = true;
                    textBox2.Text = password[0];
                    Ok = true;
                }
                if (!Ok)
                    textBox2.Text = "хеш не найден";
            }
            else
            {
                this.textBox2.Visible = true;
                textBox2.Text = "подтвердите пароль";
                textBox1.Text = "ошибка";
            }
        }
        //
        //В методе блокировкаToolStripMenuItem_Click удаляются административные права
        //(для их восстановления необходимо подтвердить специальный пароль),
        //а также блокируется многие функции программы, чтобы получить к ним доступ
        //(разблокировать программу), необходимо подтвердить пароль.
        //
        private void блокировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pas = false;
            pas0 = false;
            textBox1.Text = "программа заблокирована";
            this.textBox2.Visible = false;
        }
        //
        //В методе изменитьСпециальныйПарольToolStripMenuItem_Click хешируется текст элемента textBox1,
        //если пользователь имеет специальные права, то обновляется хеш специального пароля.
        //Данный метод доступен только администратору, если пользователь не имеет доступа,
        //программа выдаст ошибку и попросить пользователя подтвердить специальный пароль.
        //
        private void изменитьСпециальныйПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox2.Visible = true;
            if (pas0)
            {
                string a = password[0];
                textBox2.Text = "специальный пароль изменен";
                password[0] = Processor.GetHashString(textBox1.Text);
                for (int i = 0; i < Ihash; i++)
                {
                    if (HASH[i] == a)
                        HASH[i] = password[0];
                }
                
                textBox1.Text = Console.ReadLine();
            }
            else
            {
                textBox2.Text = "подтвердите специальный пароль";
                textBox1.Text = "ошибка";
            }
        }
        //
        //В методе отчиститьToolStripMenuItem_Click отчищается форма.
        //
        private void отчиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox2.Visible = false;
            textBox1.Text = Console.ReadLine();
        }
        //
        //В методе зашифроватьToolStripMenuItem1_Click введенный текст шифруется с помощью метода
        //ToAes256, после чего результат шифрования конвертируется в строку и выводиться.
        //Данный метод становиться недоступным,после блокировки и до подтверждения пароля.
        //
        private void зашифроватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (pas)
            {
                this.textBox2.Visible = false;
                string post = textBox1.Text;
                textBox1.Text = Convert.ToBase64String(Processor.ToAes256(post, aeskey));
            }
            else
            {
                this.textBox2.Visible = true;
                textBox2.Text = "подтвердите пароль";
                textBox1.Text = "ошибка";
            }
        }
        //
        //В методе зашифроватьToolStripMenuItem1_Click введенный текст  конвертируется
        //в массив байтов, после дешифруется с помощью метода FromAes256 и выводиться.
        //Данный метод становиться недоступным,после блокировки и до подтверждения пароля.
        //
        private void расшифроватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (pas)
                {
                    Mypost = Convert.FromBase64String(textBox1.Text);
                    textBox2.Text = Processor.FromAes256(Mypost, aeskey);
                    this.textBox2.Visible = true;
                }
                else
                {
                    this.textBox2.Visible = true;
                    textBox2.Text = "подтвердите пароль";
                    textBox1.Text = "ошибка";

                }
            }
            catch (OverflowException ex1)
            {
                this.textBox2.Visible = true;
                textBox2.Text = "Необхоимо сначала зашифровать данные. Ошибка: " + ex1.Message;
            }
            catch (CryptographicException ex2)
            {
                this.textBox2.Visible = true;
                textBox2.Text = "Невозможно расшифровать зашифрованное другим методом.";
            }
            catch (FormatException ex3)
            {
                this.textBox2.Visible = true;
                textBox2.Text = "Неверно введены данные, расшифровка невозможна. Ошибка: "
                    + ex3.Message;
            }
        }
        //
        //В методе зашифроватьToolStripMenuItem2_Click введенный текст шифруется с помощью метода
        //Encoding.UTF8.GetBytes, затем создается подпись на основе массива байтов(зашифрованый
        //текст) и объекта класса CngKey MyKeySignature с помощью CreateSignature.
        //Далее массив байтов конвертируется в строку и выводится на экран.
        //Данный метод становиться недоступным,после блокировки и до подтверждения пароля.
        //
        private void зашифроватьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (pas)
            {
                this.textBox2.Visible = false;
                Processor.CreateKeys();
                byte[] MyData1 = Encoding.UTF8.GetBytes(textBox1.Text);
                byte[] MySignature1 = Processor.CreateSignature(MyData1, MyKeySignature);
                MyData = MyData1;
                MySignature = MySignature1;
                textBox1.Text = Convert.ToBase64String(MyData1);
            }
            else
            {
                this.textBox2.Visible = true;
                textBox2.Text = "подтвердите пароль";
                textBox1.Text = "ошибка";
            }
        }
        //
        //В методе зашифроватьToolStripMenuItem1_Click введенный текст  конвертируется
        //в массив байтов, после чего дешифруется  с помощью метода Encoding.UTF8.GetString.
        //Данный метод становиться недоступным,после блокировки и до подтверждения пароля.
        //
        private void расшифроватьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                if (pas)
                {
                    this.textBox2.Visible = true;
                    byte [] DMyData = Convert.FromBase64String(textBox1.Text);
                    textBox2.Text = Encoding.UTF8.GetString(DMyData);                   
                }
                else
                {
                    this.textBox2.Visible = true;
                    textBox2.Text = "подтвердите пароль";
                    textBox1.Text = "ошибка";
                }
            }
            catch (ArgumentNullException ex1)
            {
                this.textBox2.Visible = true;
                textBox2.Text = "Необхоимо сначала зашифровать данные. Ошибка: " + ex1.Message;
            }
            catch (CryptographicException ex2)
            {
                this.textBox2.Visible = true;
                textBox2.Text = "Ошибка: " + ex2.Message;
            }
            catch (FormatException ex3)
            {
                this.textBox2.Visible = true;
                textBox2.Text = "Неверно введены данные, расшифровка невозможна. Ошибка: " 
                    + ex3.Message;
            }
        }
        //
        //В методе подписьToolStripMenuItem1_Click подпись конвертируется в строку и 
        //выводится на эран.
        //Данный метод становиться недоступным,после блокировки и до подтверждения пароля.
        //
        private void подписьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (pas)
                {
                    this.textBox2.Visible = true;
                    textBox2.Text = Convert.ToBase64String(MySignature);
                }
                else
                {
                    this.textBox2.Visible = true;
                    textBox2.Text = "подтвердите пароль";
                    textBox1.Text = "ошибка";
                }
            }
            catch (ArgumentNullException ex)
            {
                this.textBox2.Visible = true;
                textBox2.Text =
                    "Необхоимо сначала зашифровать данные, чтобы появилась подпись. Ошибка: "
                    + ex.Message;
            }
        }
        //
        //В методе проверитьПодписьToolStripMenuItem_Click введенный текст  конвертируется
        //в массив байтов, после чего при помощи метода VerifySignature проверяется подпись.
        //Если введенная отличается от имеющейся, то выводится сообщение "подпись не подтверждена".
        //Данный метод доступен только администратору, если пользователь не имеет доступа,
        //программа выдаст ошибку и попросить пользователя подтвердить специальный пароль.
        //
        private void проверитьПодписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.textBox2.Visible = true;
                if (pas0)
                {
                    byte[] MySignature1 = Convert.FromBase64String(textBox1.Text);

                    if (Processor.VerifySignature(MyData, MySignature1, MyPubKeyBlob))
                    {
                        textBox2.Text = "подпись подтверждена";
                    }
                    else
                        textBox2.Text = "подпись не подтверждена";
                }
                else
                {

                    textBox2.Text = "подтвердите специальный пароль";
                    textBox1.Text = "ошибка";
                }
            }
            catch(ArgumentNullException ex1)
            {
                this.textBox2.Visible = true;
                textBox2.Text = "Необхоимо ввести подпись для проверки. Ошибка: " + ex1.Message;
            }
            catch(FormatException ex2)
            {
                this.textBox2.Visible = true;
                textBox2.Text = "Неверно введены данные, проверить водпись невозможно. Ошибка: " 
                    + ex2.Message;
            }
        }
        //
        //В методе закрытьToolStripMenuItem_Click закрывается форма.
        //
        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        //В методе новаяФормаToolStripMenuItem_Click открывается новая форма.
        //
        private void новаяФормаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 myForm1 = new Form1();
            myForm1.Show();
        }

    }

    public class Processor
    {
        //
        //В методо VerifySignature проверяется подпись. Для этого создается объект класса CngKey
        //и присваивается ему новый открытый ключ при помощи метода CngKey.Import. Далее 
        //инициализируется объект signingAlg класса ECDsaCng, затем используется метод 
        //signingAlg.VerifyData и возвращается результат(true or false).
        //
        public static bool VerifySignature(byte[] data, byte[] signature, byte[] pubKey)
        {
            bool retValue = false;
            using (CngKey key = CngKey.Import(pubKey, CngKeyBlobFormat.GenericPublicBlob))
            {
                var signingAlg = new ECDsaCng(key);
                retValue = signingAlg.VerifyData(data, signature);
                signingAlg.Clear();
            }
            return retValue;
        }
        //
        //В методе CreateSignature создается подпись, для этого инициализируется объект signingAlg
        //класса ECDsaCng, затем при помощи метода igningAlg.SignData создается и выводится подпись.
        //
        public static byte[] CreateSignature(byte[] data, CngKey key)
        {
            byte[] signature;
            var signingAlg = new ECDsaCng(key);
            signature = signingAlg.SignData(data);
            signingAlg.Clear();
            return signature;
        }
        //
        //В методе CreateKeys создается открытый ключ, а также задается алгоритм шифрования.
        //
        public static void CreateKeys()
        {
            Form1.MyKeySignature = CngKey.Create(CngAlgorithm.ECDsaP256);
            Form1.MyPubKeyBlob = Form1.MyKeySignature.Export(CngKeyBlobFormat.GenericPublicBlob);
        }
        //
        //В методе GetHashString вычесляется и возвращается хеш полученной на входе строки.
        //Для этого строка переводится  в массив байтов, далее инициализируется объект класса
        //MD5CryptoServiceProvider и вычисляется хеш при помощи метода CSP.ComputeHash,
        //затем массив хеша в строку переводится и она возвращается.
        //
        public static string GetHashString(string s)
        {
            //переводим строку в байт-массим  
            byte[] bytes = Encoding.Unicode.GetBytes(s);

            //создаем объект для получения средст шифрования  
            MD5CryptoServiceProvider CSP =
                new MD5CryptoServiceProvider();

            //вычисляем хеш-представление в байтах  
            byte[] byteHash = CSP.ComputeHash(bytes);

            string hash = string.Empty;

            //формируем одну цельную строку из массива  
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);

            return hash;
        }
        //
        //В методе ToAes256 симметрично шифруется полученная на входе строка. Для этого определяется
        //объект основных операции криптографических преобразований(создание объекта шифратора),  
        //далееинициализируется объект класса MemoryStream(создание потока), инициализируется 
        //объект класса CryptoStream(определение потока, который связывает потоки данных
        //с криптографическими преобразованиями), инициализируется объект класса StreamWriter
        //(для записи символов в поток в определенной кодировке), после записывается строка и 
        //закрывается последний поток, затем считываеется и возвращается зашифрованный поток байтов,
        //к которому был прикреплен инициализирующий вектор(соль). 
        //
        public static byte[] ToAes256(string src, AesManaged aeskey)
        {
            byte[] encrypted;
            ICryptoTransform crypt = aeskey.CreateEncryptor(aeskey.Key, aeskey.IV);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, crypt, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(src);
                        sw.Close();
                    }
                }
                encrypted = ms.ToArray();
                ms.Close();
            }
            return encrypted.Concat(aeskey.IV).ToArray();
        }
        //
        //В методе FromAes256 симметрично расшифровывается полученный на входе массив байтов. 
        //Для этого создается массив байтов, с помощбю которого открепляется соль, после
        //определяется объект основных операции криптографических преобразований(создание объекта 
        //шифратора), далее, инициализируется объект класса MemoryStream(создание потока), 
        //инициализируется объект класса CryptoStream(определение потока, который связывает потоки 
        //данных с криптографическими преобразованиями), инициализируется объект класса StreamWriter
        //(для записи символов в поток в определенной кодировке), после считывается строка и 
        //закрывается последний поток, затем возвращается расшифрованный строка. 
        //
        public static string FromAes256(byte[] shifr, AesManaged aeskey)
        {
            byte[] bytesIv = new byte[16];
            byte[] mess = new byte[shifr.Length - 16];
            for (int i = shifr.Length - 16, j = 0; i < shifr.Length; i++, j++)
                bytesIv[j] = shifr[i];
            for (int i = 0; i < shifr.Length - 16; i++)
                mess[i] = shifr[i];
            string text = "";
            byte[] data = mess;
            ICryptoTransform crypt = aeskey.CreateDecryptor(aeskey.Key, aeskey.IV);
            using (MemoryStream ms = new MemoryStream(data))
            {
                using (CryptoStream cs = new CryptoStream(ms, crypt, CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(cs))
                    {
                        text = sr.ReadToEnd();
                        sr.Close();
                    }
                }
            }
            return text;
        }
    }
}
