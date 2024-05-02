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

- WPF에서 중요한 개념(Winform과 차이점)
    - 데이터 바인딩 : 바인딩 키워드로 코드와 분리
        - 옵저버 패턴 : 값이 변경된 사실을 사용자에게 공지 OnPropertyChange 이벤트
        - 디자인 리소스 : 각 컨트롤마다 디자인(X), 리소스로 디자인을 공유
            - 각 화면당 Resources : 자기 화면에만 적용되는 디자인
            - App.xaml Resources : 애플리케이션 전체에 적용되는 디자인
            - 리소스 Dictionary : 공유할 디자인 내용이 많을 때 파일로 별도 지정

- WPF MVVM
    - MVC (Model View controller 패턴)
        - 웹개발(Spring, ASP.NET MVC, DJango, ect...) 현재도 사용되고 있음
        - Model : Data 입출력 처리를 담당
        - View : 디스플레이 화면 담당
        - Controller : View를 제어, 모델 처리 중앙에 관장

    - MVVM (Model View ViewModel)
        - Model : Data 입출력(DB side)
        - View : 화면, 순수 xaml로만 구성
        - ViewModel : 뷰에 대한 메서드, 액션, INotifyPropertyChanged를 구현

    ![MVVM 페턴]()

    - 권장 구현 방법
        - ViewModel 생성, 알림 속성 구현
        - View에 ViewModel을 데이터 바인딩
        - Model DB 작업 독립적으로 구현

    - MVVM 구현을 도와주는 프레임워크
        - ~~MvvmLight.Toolkit~~ : 3rd Party 개발, 2009년부터 시작 2014년도 이후 더이상 개발이나 지원이 없음.
        - **Caliburn.Micro** : 3rd Party 개발, MVVM이 아주 간단, 강력. 중소형 프로젝트에 적합. 디버깅이 조금 어려움
        - AvaloniaUI : 3rd Party 개발, 크로스 플랫폼. 디자인 최고!
        - Prism : Microsoft 개발. 아주 어려움. 대규모 프로젝트에 활용

    - Caliburn.Micro
        - 1. 프로젝트 생성 후 MainWindow.xaml 삭제
        - 2. Models, Views, ViewModels 폴더(네임스페이스) 생성
        - 3. 종속성 NuGet패키지 Caliburn.Micro 설치
        - 4. 루트 폴더에 Bootstrapper.cs 클래스 생성
        - 5. App.xaml에서 StartupUrl 삭제
        - 6. App.xaml에 Bootstrapper 클래스를 리소스 Dictionary에 등록
        - 7. App.xaml.cs에 App() 생성자 추가
        - 8. ViewModels 폴더에 MainViewModel.cs 클래스 생성
        - 9. Bootstrapper.cs에 OmStartup()에 내용을 변경
        - 10. Views 폴더에 MainView.xaml

    - 작업 분리
        - DB 개발자 : DB 테이블 생성, Models에 클래스 작업
        - Xaml 디자인 : Views 폴더에 있는 Xaml 파일을 디자인 작업