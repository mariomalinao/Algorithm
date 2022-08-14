using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.CoinChanger
{
    public class Processor
    {
        private const double QUARTER = 0.25;
        private const double DIME = 0.1;
        private const double NICKEL = 0.05;
        private const double PENNY = 0.01;

        public string Run(double amount)
        {
            var change = new Dictionary<string, int>();

            while (true)
            {
                if ((amount/ QUARTER) >= 1)
                {
                    change.Add(nameof(QUARTER), (int) Math.Truncate(amount / QUARTER));
                    amount = Math.Round(amount % QUARTER,2);
                    continue;
                }
                else if ((amount / DIME) >= 1)
                {
                    change.Add(nameof(DIME), (int)Math.Truncate(amount / DIME));
                    amount = Math.Round(amount % DIME, 2);
                    continue;
                }
                else if ((amount / NICKEL) >= 1)
                {
                    change.Add(nameof(NICKEL), (int)Math.Truncate(amount / NICKEL));
                    amount = Math.Round(amount % NICKEL, 2);
                    continue;
                }
                else if ((amount / PENNY) >= 1)
                {
                    change.Add(nameof(PENNY), (int)Math.Truncate(amount / PENNY));
                    break;
                }
                else
                    break;
            }


            return string.Join(Environment.NewLine,change.Select(x => $"{x.Key}: {x.Value}"));
        }
    }
}
