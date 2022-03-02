using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wyscig_tuptusia
{
    public class guy
    {
        public RadioButton radioButton;
        private Label label;
        public bet myBet;
        

        private string name;
        private int cash;
  


        public guy(string name,int cash, RadioButton radioButton, Label label)
        {
            this.name = name;
            this.cash = cash;
            this.radioButton = radioButton;
            this.label = label;

        }

        public void UpdateLabels()
        {
            if (this.myBet==null)
                this.label.Text = name + " nie obstawił zakładu.";
            else
                this.label.Text = name +" postawił "+ myBet.amount+ " na jezyka nr"+ myBet.Dog+".";
        }

        public bool PlaceBet(int _amount,int dogToWin)
        {
            myBet = new bet() { amount = _amount, Dog = dogToWin, bettor = this };
            return (this.myBet.bettor.cash > 5) ? true : false;
        }

        public void ClearBet()
        {
            myBet = null;
        }

        public void Collect(int Winner)
        {
            this.cash += myBet.PayOut(Winner);
        }
        public void UpdateRadios()
        {
            this.radioButton.Text = name + " ma " + cash + " zł.";
        }
    }
}
