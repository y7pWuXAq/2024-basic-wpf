## WPF 윈폼 개발학습
2024년 IoT 개발자 WPF 리포지토리


### DAY 01

- WPF 기본학습
    - winforms 확장한 WPF
        - 이전의 Winform은 비트맵 방식(2D)
        - WPF 이미지 벡터방식
        - XAML 화면 디자인 : 안드로이드 개발 Java XML로 화면 디자인과 동일, PyQt로 디자인과 동일
    
    - XAML(재믈)
        - 여는 태그 <Window>, 닫는 태그 </Window>
        - 합치면 <Window /> : Window 태그 안에 다른 객체가 없다는 뜻
        - 여는 태그와 닫는 태그사이에 다른 태그(객체)를 넣어서 디자인

    - WPF 기본 사용법
        - Winform과는 다르게 코딩으로 디자인을 함
    
    - 레이아웃
        - Grid : WPF에서가장 많이 사용하는 대표적은 레이아웃
        - StackPanel : 스택으로 컨트롤을 쌓는 레이아웃
        - Canvas : 미술 캔버스와 유사한 레이아웃
        - DockPanel : 컨트롤을 방향에 따라서 도킹시키는 레이아웃
        - Margin : 여백기능, 앵커랑 같이함(중요!)
    
    
### DAY 02

- WPF 기본학습
    - 데이터 바인딩 : 데이터 소스(DB, 엑셀, .txt, 클라우드에서 넘어오는 데이터 원본)에 데이터를 쉽게 가져다 쓰기 위한 데이터 핸들링 방법
        - xaml 형식 : {Binding Path=속성, ElemenrName=객체, Mode=(OneWay | TowWay), StringFormat={}{0:#,#}}
        - dataContext : 데이터를 담아서 전달하는 이름
        - 전통적인 윈폼 코드비하인드에서 데이터를 처리하는 것을 지양! : 디자인, 개발 부분 분리하기 위해서


### DAY 03

- WPF 기본학습
    - 데이터 바인딩 마무리
    - 디자인 리소스

- WPF MVVM