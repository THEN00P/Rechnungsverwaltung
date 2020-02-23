using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;

namespace ZusatzComponents
{
    public partial class TextBoxPlus : UserControl
    {
        public Color BorderFocusColor { get; set; } = Color.Gray;


        Label bottomBorder = new Label()
        { Height = 2, Dock = DockStyle.Bottom, BackColor = Color.Black };

        PlaceholderTextBox pTextBox = new PlaceholderTextBox()
        { Dock = DockStyle.Fill, BorderStyle = BorderStyle.None };

        UserControl wrapper = new UserControl()
        { Dock = DockStyle.Fill };

        Color _BorderColor = Color.Black;

        public Color BorderColor
        {
            get => _BorderColor;
            set
            {
                _BorderColor = value;
                bottomBorder.BackColor = value;
            }
        }

        public Point PaddingLeftRight { get; set; } = new Point(0,0);

        public Color PlaceholderForeColor
        {
            get => pTextBox.PlaceholderForeColor;
            set => pTextBox.PlaceholderForeColor = value;
        }

        public char PasswordChar
        {
            get => pTextBox.pwChar;
            set => pTextBox.pwChar = value;
        }

        public string PlaceHolderText
        {
            get => pTextBox.PlaceHolderText;
            set => pTextBox.PlaceHolderText = value;
        }
        public new Size Size
        {
            get => base.Size;
            set
            {
                int autoPadding = (value.Height - (pTextBox.Height + bottomBorder.Height)) / 2;
                wrapper.Padding = new Padding(PaddingLeftRight.X, autoPadding, PaddingLeftRight.Y, autoPadding);
                base.Size = value;
            }
        }
        public new Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                pTextBox.BackColor = value;
            }
        }
        public new Font Font
        {
            get => pTextBox.Font;
            set
            {
                base.Font = value;
                pTextBox.Font = value;
            }
        }
        public new Color ForeColor
        {
            get => pTextBox.ForeColor;
            set
            {
                base.ForeColor = value;
                pTextBox.ForeColor = value;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public new string Text
        {
            get => pTextBox.Text;
            set {
                base.Text = value;
                pTextBox.Text = value;
            }
        }

        public TextBoxPlus()
        {
            this.Cursor = Cursors.IBeam;

            this.Controls.Add(wrapper);

            pTextBox.GotFocus += PTextBox_GotFocus;
            pTextBox.LostFocus += PTextBox_LostFocus;
            wrapper.Controls.Add(pTextBox);

            bottomBorder.BackColor = BorderColor;
            this.Controls.Add(bottomBorder);
        }


        private void PTextBox_LostFocus(object sender, EventArgs e)
        {
            bottomBorder.BackColor = BorderColor;
        }

        private void PTextBox_GotFocus(object sender, EventArgs e)
        {
            bottomBorder.BackColor = BorderFocusColor;
        }
    }



    public partial class PlaceholderTextBox : TextBox
    {
        bool isPlaceHolder = true;

        public char pwChar;

        public Color PlaceholderForeColor { get; set; } = Color.Gray;

        string _placeHolderText;
        public string PlaceHolderText
        {
            get => _placeHolderText;
            set
            {
                _placeHolderText = value;
                setPlaceholder();
            }
        }

        public new string Text
        {
            get => isPlaceHolder ? string.Empty : base.Text;
            set {
                removePlaceHolder();
                base.Text = value;
            }
        }

        Color _ForeColor;
        public new Color ForeColor
        {
            get => _ForeColor;
            set {
                _ForeColor = value;

                if(!isPlaceHolder || value == PlaceholderForeColor)
                    base.ForeColor = value;
            }
        }

        public new bool AutoSize { get => false; }
                

        private void setPlaceholder()
        {
            if (string.IsNullOrEmpty(base.Text))
            {
                PasswordChar = '\0';
                base.Text = PlaceHolderText;
                base.ForeColor = PlaceholderForeColor;
                this.Font = new Font(this.Font, FontStyle.Italic);
                isPlaceHolder = true;
            }
        }

        private void removePlaceHolder()
        {
            if (isPlaceHolder)
            {
                PasswordChar = pwChar;
                base.Text = "";
                base.ForeColor = _ForeColor;
                this.Font = new Font(this.Font, FontStyle.Regular);
                isPlaceHolder = false;
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            setPlaceholder();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            removePlaceHolder();
        }
    }
}
