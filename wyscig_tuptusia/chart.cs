using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wyscig_tuptusia
{
    public class chart
    {
        public Random random;
        public PictureBox picture;
        public int StartingPosition;
        private PictureBox _trasa;

        public chart(PictureBox picture,PictureBox _trasa,int StartingPosition,Random random)
        {
            this.picture = picture;
            this.StartingPosition = StartingPosition;
            this.random = random;
            this._trasa = _trasa; 
        }
        
        public void Run()
        {
            
            picture.Left += random.Next(10, 60);
        }
        public bool Meta()
        {
            return picture.Left>_trasa.Right*0.85? true:false;
        }
    }
}
