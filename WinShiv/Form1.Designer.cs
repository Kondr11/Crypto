namespace WinShiv
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сообщениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хешшифToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьпарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверитьпарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьХешToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.блокировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьСпециальныйПарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.симшифToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зашифроватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.расшифроватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.асимшифToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зашифроватьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.расшифроватьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.подписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверитьПодписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяФормаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider1.SetHelpString(this.textBox1, "сначала введите что-либо в это поле, а затем используйте функции меню");
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.helpProvider1.SetShowHelp(this.textBox1, true);
            this.textBox1.Size = new System.Drawing.Size(284, 71);
            this.textBox1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBox1, "сначала введите что-либо в это поле, а затем используйте функции меню");
            // 
            // textBox2
            // 
            this.textBox2.AcceptsTab = true;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.helpProvider1.SetHelpString(this.textBox2, "информационное поле");
            this.textBox2.Location = new System.Drawing.Point(0, 95);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.helpProvider1.SetShowHelp(this.textBox2, true);
            this.textBox2.Size = new System.Drawing.Size(284, 167);
            this.textBox2.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBox2, "информационное поле");
            this.textBox2.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сообщениеToolStripMenuItem,
            this.программаToolStripMenuItem,
            this.формаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сообщениеToolStripMenuItem
            // 
            this.сообщениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьТекстToolStripMenuItem,
            this.хешшифToolStripMenuItem});
            this.сообщениеToolStripMenuItem.Name = "сообщениеToolStripMenuItem";
            this.сообщениеToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.сообщениеToolStripMenuItem.Text = "Программа";
            this.сообщениеToolStripMenuItem.ToolTipText = "меню функций для программы";
            // 
            // изменитьТекстToolStripMenuItem
            // 
            this.изменитьТекстToolStripMenuItem.Name = "изменитьТекстToolStripMenuItem";
            this.изменитьТекстToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.изменитьТекстToolStripMenuItem.Text = "Отчистить";
            this.изменитьТекстToolStripMenuItem.ToolTipText = "отчищает вверхнее поле";
            this.изменитьТекстToolStripMenuItem.Click += new System.EventHandler(this.изменитьТекстToolStripMenuItem_Click);
            // 
            // хешшифToolStripMenuItem
            // 
            this.хешшифToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьпарольToolStripMenuItem,
            this.проверитьпарольToolStripMenuItem,
            this.удалитьПарольToolStripMenuItem,
            this.показатьХешToolStripMenuItem,
            this.блокировкаToolStripMenuItem,
            this.изменитьСпециальныйПарольToolStripMenuItem});
            this.хешшифToolStripMenuItem.Name = "хешшифToolStripMenuItem";
            this.хешшифToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.хешшифToolStripMenuItem.Text = "хеш-шиф";
            this.хешшифToolStripMenuItem.ToolTipText = "функции использующие хеш шифрование";
            // 
            // добавитьпарольToolStripMenuItem
            // 
            this.добавитьпарольToolStripMenuItem.Name = "добавитьпарольToolStripMenuItem";
            this.добавитьпарольToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.добавитьпарольToolStripMenuItem.Text = "добавить пароль";
            this.добавитьпарольToolStripMenuItem.ToolTipText = "Сначала подтвердите специальный пароль, если он не был подтвержден ранее.\r\nЗатем " +
    "введите пароль, который хотите добавить, в верхнее поле, затем нажмите на эту кн" +
    "опку";
            this.добавитьпарольToolStripMenuItem.Click += new System.EventHandler(this.добавитьпарольToolStripMenuItem_Click);
            // 
            // проверитьпарольToolStripMenuItem
            // 
            this.проверитьпарольToolStripMenuItem.Name = "проверитьпарольToolStripMenuItem";
            this.проверитьпарольToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.проверитьпарольToolStripMenuItem.Text = "проверить пароль";
            this.проверитьпарольToolStripMenuItem.ToolTipText = "введите пароль в верхнее поле, а затем нажмите на эту кнопку для подтверждения па" +
    "роля";
            this.проверитьпарольToolStripMenuItem.Click += new System.EventHandler(this.проверитьпарольToolStripMenuItem_Click);
            // 
            // удалитьПарольToolStripMenuItem
            // 
            this.удалитьПарольToolStripMenuItem.Name = "удалитьПарольToolStripMenuItem";
            this.удалитьПарольToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.удалитьПарольToolStripMenuItem.Text = "удалить пароль";
            this.удалитьПарольToolStripMenuItem.ToolTipText = "Сначала подтвердите специальный пароль, если он не был подтвержден ранее.\r\nЗатем " +
    "введите в верхнее поле пароль, который хотите удалить, затем нажмите на эту кноп" +
    "ку";
            this.удалитьПарольToolStripMenuItem.Click += new System.EventHandler(this.удалитьПарольToolStripMenuItem_Click);
            // 
            // показатьХешToolStripMenuItem
            // 
            this.показатьХешToolStripMenuItem.Name = "показатьХешToolStripMenuItem";
            this.показатьХешToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.показатьХешToolStripMenuItem.Text = "показать хеш";
            this.показатьХешToolStripMenuItem.ToolTipText = "введите в верхнее поле пароль, хеш которого вы хотите увидеть, а затем нажмите на" +
    " эту кнопку";
            this.показатьХешToolStripMenuItem.Click += new System.EventHandler(this.показатьХешToolStripMenuItem_Click);
            // 
            // блокировкаToolStripMenuItem
            // 
            this.блокировкаToolStripMenuItem.Name = "блокировкаToolStripMenuItem";
            this.блокировкаToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.блокировкаToolStripMenuItem.Text = "блокировка";
            this.блокировкаToolStripMenuItem.ToolTipText = resources.GetString("блокировкаToolStripMenuItem.ToolTipText");
            this.блокировкаToolStripMenuItem.Click += new System.EventHandler(this.блокировкаToolStripMenuItem_Click);
            // 
            // изменитьСпециальныйПарольToolStripMenuItem
            // 
            this.изменитьСпециальныйПарольToolStripMenuItem.Name = "изменитьСпециальныйПарольToolStripMenuItem";
            this.изменитьСпециальныйПарольToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.изменитьСпециальныйПарольToolStripMenuItem.Text = "изменить специальный пароль";
            this.изменитьСпециальныйПарольToolStripMenuItem.ToolTipText = "Сначала подтвердите специальный пароль, если он не был подтвержден ранее.\r\nПосле " +
    "введите новый специальный пароль в верхнее поле, затем нажмите на эту кнопку";
            this.изменитьСпециальныйПарольToolStripMenuItem.Click += new System.EventHandler(this.изменитьСпециальныйПарольToolStripMenuItem_Click);
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчиститьToolStripMenuItem,
            this.симшифToolStripMenuItem,
            this.асимшифToolStripMenuItem});
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.программаToolStripMenuItem.Text = "Сообщение";
            this.программаToolStripMenuItem.ToolTipText = "функции для взаимодействия я сообщениями";
            // 
            // отчиститьToolStripMenuItem
            // 
            this.отчиститьToolStripMenuItem.Name = "отчиститьToolStripMenuItem";
            this.отчиститьToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.отчиститьToolStripMenuItem.Text = "Отчистить";
            this.отчиститьToolStripMenuItem.ToolTipText = "отчищает вверхнее поле";
            this.отчиститьToolStripMenuItem.Click += new System.EventHandler(this.отчиститьToolStripMenuItem_Click);
            // 
            // симшифToolStripMenuItem
            // 
            this.симшифToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зашифроватьToolStripMenuItem1,
            this.расшифроватьToolStripMenuItem1});
            this.симшифToolStripMenuItem.Name = "симшифToolStripMenuItem";
            this.симшифToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.симшифToolStripMenuItem.Text = "сим-шиф";
            this.симшифToolStripMenuItem.ToolTipText = "функции использующие симметричное шифрование";
            // 
            // зашифроватьToolStripMenuItem1
            // 
            this.зашифроватьToolStripMenuItem1.Name = "зашифроватьToolStripMenuItem1";
            this.зашифроватьToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.зашифроватьToolStripMenuItem1.Text = "зашифровать";
            this.зашифроватьToolStripMenuItem1.ToolTipText = "введите текст, который хотете зашифровать, в верхнее поле, затем нажмите на эту к" +
    "нопку";
            this.зашифроватьToolStripMenuItem1.Click += new System.EventHandler(this.зашифроватьToolStripMenuItem1_Click);
            // 
            // расшифроватьToolStripMenuItem1
            // 
            this.расшифроватьToolStripMenuItem1.Name = "расшифроватьToolStripMenuItem1";
            this.расшифроватьToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.расшифроватьToolStripMenuItem1.Text = "расшифровать";
            this.расшифроватьToolStripMenuItem1.ToolTipText = "введите текст, котрый хотите расшифровать, в верхнее поле, а затем нажмите на эту" +
    " кнопку";
            this.расшифроватьToolStripMenuItem1.Click += new System.EventHandler(this.расшифроватьToolStripMenuItem1_Click);
            // 
            // асимшифToolStripMenuItem
            // 
            this.асимшифToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зашифроватьToolStripMenuItem2,
            this.расшифроватьToolStripMenuItem2,
            this.подписьToolStripMenuItem,
            this.проверитьПодписьToolStripMenuItem});
            this.асимшифToolStripMenuItem.Name = "асимшифToolStripMenuItem";
            this.асимшифToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.асимшифToolStripMenuItem.Text = "асим-шиф";
            this.асимшифToolStripMenuItem.ToolTipText = "функции использующие асимметричное шифрование";
            // 
            // зашифроватьToolStripMenuItem2
            // 
            this.зашифроватьToolStripMenuItem2.Name = "зашифроватьToolStripMenuItem2";
            this.зашифроватьToolStripMenuItem2.Size = new System.Drawing.Size(181, 22);
            this.зашифроватьToolStripMenuItem2.Text = "зашифровать";
            this.зашифроватьToolStripMenuItem2.ToolTipText = "введите текст, который хотете зашифровать, в верхнее поле, затем нажмите на эту к" +
    "нопку";
            this.зашифроватьToolStripMenuItem2.Click += new System.EventHandler(this.зашифроватьToolStripMenuItem2_Click);
            // 
            // расшифроватьToolStripMenuItem2
            // 
            this.расшифроватьToolStripMenuItem2.Name = "расшифроватьToolStripMenuItem2";
            this.расшифроватьToolStripMenuItem2.Size = new System.Drawing.Size(181, 22);
            this.расшифроватьToolStripMenuItem2.Text = "расшифровать";
            this.расшифроватьToolStripMenuItem2.ToolTipText = "введите текст, котрый хотите расшифровать, в верхнее поле, а затем нажмите на эту" +
    " кнопку";
            this.расшифроватьToolStripMenuItem2.Click += new System.EventHandler(this.расшифроватьToolStripMenuItem2_Click);
            // 
            // подписьToolStripMenuItem
            // 
            this.подписьToolStripMenuItem.Name = "подписьToolStripMenuItem";
            this.подписьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.подписьToolStripMenuItem.Text = "подпись";
            this.подписьToolStripMenuItem.ToolTipText = "Сначала зашифруйте текст используя ассиметричное шифрование.\r\nПосле нажмите на эт" +
    "у кнопку, чтобы увидеть подпись.";
            this.подписьToolStripMenuItem.Click += new System.EventHandler(this.подписьToolStripMenuItem1_Click);
            // 
            // проверитьПодписьToolStripMenuItem
            // 
            this.проверитьПодписьToolStripMenuItem.Name = "проверитьПодписьToolStripMenuItem";
            this.проверитьПодписьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.проверитьПодписьToolStripMenuItem.Text = "проверить подпись";
            this.проверитьПодписьToolStripMenuItem.ToolTipText = "Сначала зашифруйте текст используя ассиметричное шифрование.\r\nПосле подтвердите с" +
    "пециальный пароль.\r\nЗатем нажмите на эту кнопку, чтобы проверить подпись.\r\n";
            this.проверитьПодписьToolStripMenuItem.Click += new System.EventHandler(this.проверитьПодписьToolStripMenuItem_Click);
            // 
            // формаToolStripMenuItem
            // 
            this.формаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяФормаToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.формаToolStripMenuItem.Name = "формаToolStripMenuItem";
            this.формаToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.формаToolStripMenuItem.Text = "Форма";
            this.формаToolStripMenuItem.ToolTipText = "функции связанные с формой";
            // 
            // новаяФормаToolStripMenuItem
            // 
            this.новаяФормаToolStripMenuItem.Name = "новаяФормаToolStripMenuItem";
            this.новаяФормаToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.новаяФормаToolStripMenuItem.Text = "Новая форма";
            this.новаяФормаToolStripMenuItem.ToolTipText = "Создает новую независимую от другой форму.";
            this.новаяФормаToolStripMenuItem.Click += new System.EventHandler(this.новаяФормаToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.ToolTipText = "закрывает форму";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " ";
            this.toolTip1.SetToolTip(this, "Если фунция запрашивает специальный пароль, то она предназначена для администрато" +
        "ра.");
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сообщениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem формаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяФормаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;       
        private System.Windows.Forms.ToolStripMenuItem хешшифToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьпарольToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверитьпарольToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьПарольToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьХешToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem блокировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьСпециальныйПарольToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem симшифToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem асимшифToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зашифроватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem расшифроватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem зашифроватьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem расшифроватьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem подписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверитьПодписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчиститьToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

