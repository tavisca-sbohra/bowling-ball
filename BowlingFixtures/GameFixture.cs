using System;
using Bowling;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingFixtures
{
    [TestClass]
    public class GameFixture
    {
        [TestMethod]
        public void SomeValuesOnly()
        {
           Game o = new Game();
           o.Roll(10);
           o.Roll(10);
           o.Roll(10);

           System.Diagnostics.Debug.WriteLine("value :" + o.GetScore());
            
        }


        [TestMethod]
        public void calculateScoreInBetween()
        {
            Game o = new Game();
            o.Roll(10);
            o.Roll(10);
            o.Roll(1);
            o.Roll(6);
            o.Roll(3);
            o.Roll(0);
            
           
            Assert.AreEqual(48, o.GetScore());
           
            
        }

        [TestMethod]
        public void Gutter()
         {
        Game o = new Game();
        o.Roll(0);
        o.Roll(0);
        o.Roll(0);
        o.Roll(0);
        o.Roll(0);
        o.Roll(0);
        o.Roll(0);
        o.Roll(0);
        o.Roll(0);
        o.Roll(0);
        o.Roll(0);
        o.Roll(0);
        o.Roll(0);
        o.Roll(0);
        o.Roll(0);
        o.Roll(0);
        o.Roll(0);
        o.Roll(0);
        o.Roll(0);
        o.Roll(0);
        o.Roll(0);
        Assert.AreEqual(0, o.GetScore());
         }
 
         
         [TestMethod]
         public void NoSpareNoStrike()
         {
             Game o = new Game();
             o.Roll(1);
            o.Roll(2);

             o.Roll(3);
             o.Roll(4);

             o.Roll(5);
             o.Roll(4);

             o.Roll(3);
             o.Roll(2);

             o.Roll(1);
             o.Roll(0);

             o.Roll(1);
             o.Roll(2);

             o.Roll(3);
             o.Roll(4);

             o.Roll(5);
             o.Roll(4);

             o.Roll(3);
             o.Roll(2);

             o.Roll(0);
             o.Roll(1);

             Assert.AreEqual(50, o.GetScore());
            
         }

         [TestMethod]
         public void OnlySpareAllRandom()
         {
             Game o = new Game();
             o.Roll(1);
             o.Roll(9);

             o.Roll(1);
             o.Roll(0);

             o.Roll(3);
             o.Roll(7);

             o.Roll(2);
             o.Roll(0);

             o.Roll(5);
             o.Roll(5);

             o.Roll(3);
             o.Roll(0);

             o.Roll(7);
             o.Roll(3);

             o.Roll(4);
             o.Roll(0);

             o.Roll(9);
             o.Roll(0);

             o.Roll(0);
             o.Roll(1);


             System.Diagnostics.Debug.WriteLine("value :" + o.GetScore());
         }


         
         [TestMethod]
         public void AllStrike()
         {
             Game o = new Game();
             o.Roll(10);
             o.Roll(10);

             o.Roll(10);
             o.Roll(10);

             o.Roll(10);
             o.Roll(10);

             o.Roll(10);
             o.Roll(10);

             o.Roll(10);
             o.Roll(10);

             o.Roll(10);
             o.Roll(10);

             System.Diagnostics.Debug.WriteLine("value :" +o.GetScore());
         }

         [TestMethod]
         public void RandomValues()
         {
             Game o = new Game();
             o.Roll(3);
             o.Roll(6);

             o.Roll(10);

             o.Roll(4);
             o.Roll(5);

             o.Roll(5);
             o.Roll(5);

             o.Roll(1);
             o.Roll(1);

             o.Roll(10);

             o.Roll(6);
             o.Roll(4);

             o.Roll(10);

             o.Roll(0);
             o.Roll(10);

             o.Roll(10);

             o.Roll(0);
             o.Roll(10);

             System.Diagnostics.Debug.WriteLine("value :" + o.GetScore());
         }
      }
}
