using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class Game
    {

        public int latestscore=0;
        public   int calledtimes=0;
        public int[] allpin=new int[30];

        
        public void Roll(int pins)
        {
            
            if (pins < 10)
            {
                //add it to the array ;
                //he gets another chance to roll 
             
                allpin[calledtimes] = pins;
                calledtimes =calledtimes + 1;
 
            }
            if (pins == 10)
            {
                //add it the array
                allpin[calledtimes] = pins;
                allpin[calledtimes + 1] = 0;
                calledtimes += 2;
            }
           
        }

        public int GetScore()
        {

            //caculate the latest score here 
            int i;
            
            for (i = 0; i < 20; i++)
            {
                latestscore += allpin[i];
            }
            for (i = 0; i < 19; i += 2)
            {
                if (allpin[i] == 10 && allpin[i + 2] == 10 )
                    latestscore += 10 + allpin[i+4];
                else if(allpin[i]==10 && allpin[i+2]!=10)
                    latestscore += allpin[i + 2] + allpin[i + 3];
            }

            //if (allpin[16] == 10 && allpin[18] == 10)
            //{
            //    latestscore += 10 + allpin[20];
            //}
            //if (allpin[18] == 10 )
            //{
            //    latestscore += allpin[21]+ allpin[20];
            //}
            //for (i = 1; i < 19; i+=2)
            //{
            //    if (allpin[i] == 10)
            //    {
            //        latestscore += allpin[i + 1];
            //    }
            //}

            for (i = 0; i < 20; i += 2)
            {
                if ((allpin[i] + allpin[i + 1] == 10) && (allpin[i] != 10 ))
                {
                    latestscore += allpin[i + 2];
                }
            }
                return latestscore;
          
        }  //getscore ends here

        
    }
}