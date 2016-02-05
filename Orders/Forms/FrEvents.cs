using System;
using System.Windows.Forms;
using Orders.Executers;

namespace Orders.Forms
{
    public partial class FrEvents : Form
    {
        public FrEvents()
        {
            var workExecuter = new WorkExecuter();
            var heroes = workExecuter.GetHeroes();
            var i = 0;
            foreach (var hero in heroes)
            {
                // ReSharper disable once ObjectCreationAsStatement
                new Label
                {
                    Parent = list,
                    Text = $"{hero.Name}: {hero.Type} {hero.Date:dd.MM.yyyy}",
                    Top = i * 20 + 5,
                    Left = 5,
                    AutoSize = true
                };
                i++;
            }
            ItemCount = i;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
