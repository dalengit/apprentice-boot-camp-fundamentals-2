using System;

namespace McrDigital.Bootcamp1.Checkout {
    public class Receipt {
    private string _text = String.Empty;
    private int _total;
    private int _numberOfA;
    private int _numberOfB;

    public string Text {
      get => $"{_text}Total: {_total}";
    }

        public void ScannedA() 
        {
            var quantity = 5; 
            _text = $"{_text}A: 50";
          _total += 50;
          _numberOfA++;

          if (_numberOfA % quantity == 0)
          {
              var cost = 220;
              var discount = 30;
              PrintOffer(discount, quantity, cost);
              _total -= 30;
          }

          NewLine();
        }

        public void ScannedB() 
        { 
          var quantity = 2; 
          _text = $"{_text}B: 30";
          _total += 30;
          _numberOfB++;

          if (_numberOfB % 2 == 0)
          {
              var cost = 45;
              var discount = 15;

              PrintOffer(discount, quantity, cost);
              _total -= 15;
          }
          
          NewLine();
        }

        public void ScannedC() 
        {
          _text = $"{_text}C: 20\n";
          _total += 20;
        }

        public void ScannedD() 
        {
          _text = $"{_text}D: 15\n";
          _total += 15;
        }

        private void PrintOffer(int discount, int quantity, int cost)
        {
            _text = $"{_text} - {discount} ({quantity} for {cost})";
        }

        private void NewLine()
        {
            _text = $"{_text}\n";
        }
    }
}