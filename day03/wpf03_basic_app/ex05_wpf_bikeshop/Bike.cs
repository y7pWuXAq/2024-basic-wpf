using System.Windows.Media;

namespace ex05_wpf_bikeshop
{
    // Notifier를 상속 받으면 AutoProperty {get; set;} 사용할 수 없음
    public class Bike : Notifier
    {
        private double speed; // 멤버변수
        private Color color;

        public double Speed // 속성
        {
            get { return speed; }
            set
            { // 속성 값이 변경되는 것을 알려주려면 이 작업이 반드시 필요
                speed = value;
                OnPropertyChange(nameof(Speed));
            } 
        }

        public Color Color
        {
            get { return color; }
            set
            { 
                color = value;
                OnPropertyChange(nameof(Color));
            } 
        }
    }
}