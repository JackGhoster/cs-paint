using System.DirectoryServices;
using System.Drawing.Imaging;

namespace CSPaint
{
    public partial class CSPaint : Form
    {
        static int _penSize = 5;

        Bitmap _bitmap = new Bitmap(1920, 1080);
        Pen _pen = new Pen(Color.Black, _penSize);

        bool _isDrawing = false;
        Image _openedImage;
        public CSPaint()
        {
            InitializeComponent();
            for (int y = 0; y < _bitmap.Height; y++)
            {
                for (int x = 0; x < _bitmap.Width; x++)
                {
                    _bitmap.SetPixel(x, y, Color.White);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (_isDrawing == false)
            {
                _isDrawing = true;
            }
            else
            {
                _isDrawing = false;
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            _isDrawing = false;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrawing == true)
            {
                if (_pen == null) return;
                if (_isDrawing == true)
                {
                    Graphics graphics = Graphics.FromImage(_bitmap);
                    graphics.DrawRectangle(_pen, e.X, e.Y, _penSize, 1);
                    canvas.Image = _bitmap;
                }
            }
        }

        private void white_Click(object sender, EventArgs e)
        {
            _pen.Color = Color.White;
        }

        private void green_Click(object sender, EventArgs e)
        {
            _pen.Color = Color.YellowGreen;
        }

        private void orange_Click(object sender, EventArgs e)
        {
            _pen.Color = Color.Tomato;
        }

        private void red_Click(object sender, EventArgs e)
        {
            _pen.Color = Color.DarkRed;
        }

        private void yellow_Click(object sender, EventArgs e)
        {
            _pen.Color = Color.Yellow;
        }

        private void blue_Click(object sender, EventArgs e)
        {
            _pen.Color = Color.DeepSkyBlue;
        }

        private void purple_Click(object sender, EventArgs e)
        {
            _pen.Color = Color.MediumOrchid;
        }

        private void pink_Click(object sender, EventArgs e)
        {
            _pen.Color = Color.HotPink;
        }

        private void black_Click(object sender, EventArgs e)
        {
            _pen.Color = Color.Black;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Graphics graphics = Graphics.FromImage(_bitmap);
            graphics.Clear(Color.White);
            canvas.Image = _bitmap;
        }

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _openedImage = Image.FromFile(dialog.FileName);
                canvas.Image = _openedImage;
            }
        }
        
        private void onSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = " Jpeg Image *.jpg||Bitmap Image *.bmp|";
            dlg.Title = "Save an Image file!";
            dlg.ShowDialog();
            if (dlg.FileName != null)
            {
                FileStream filestream = (FileStream)dlg.OpenFile();
                if (dlg.FilterIndex == 1)
                {
                    canvas.Image.Save($"{dlg.FileName}.jpg", ImageFormat.Jpeg);
                }
                else if (dlg.FilterIndex == 2)
                {
                    canvas.Image.Save(filestream, ImageFormat.Bmp);
                }
                filestream.Close();
            }
        }
    }
}