# basic-aspnet-2024
IoT 개발자 ASP.NET 학습 리포지토리

## 1일차
- 웹기술 개요
    - World Wide Web은 인터넷의 한 파트
    - Full Stack
        - Front-end : 웹사이트 화면으로 사람들에게 보이는 부분 기술
        - Back-end : 웹사이트 뒤에서 동작하는 서버 기술
        - Server-Operation : HW, OS, SW등 운영(클라우드)

- 업무용 웹 사이트 참조
    - https://www.ecount.com/kr/ECK/ECK004M_CN.aspx
- Front-end
    - HTML
    - CSS3
    - Javascript
    
- Back-end(서버)
    1. Java - Spring, Spring Boot, JSP, EJB ...
    2. Javascript  - Node js, Express ...
    3. Python - Django, Flask, fastAPI ...
    4. C# - ASP.NET
    5. Ruby - Ruby on rails
    6. c - cgi, fastCGI
    7. PHP

- 개발
    - 프론트엔드 전부 + 백엔드 여러 개 중 하나 + DB
    - 웹 브라우저에서 F12(개발자도구)
        - VS Code 플러그인 
            - HTML Code Snippet
            - Live Server

- HTMLS
    - XML(eXtensile Markup Lang)이 웹페이지 구성하기 위한 선행기술, 너무 복잡해서 간략화 시킨 것
    - Hyper Text Markup Language
    - 기본적으로 확장자 .html
    - Tip! lorem 탭 - 긴 샘플 텍스트 생성
    - 기본 태그(body에 사용)
        - h1 ~ h6 : 제목(마크다운 #, ##와 동일)
        - p : 일반 문장
        - div : 그룹화 구분자, 아주 중요(CSS 연계 디자인)
        - img : 이미지 표현
        - br : (break) 한 줄내리기(엔터)
        - 특수문자 : & ; 사이에 영문자로 표시(너무 많음!)
        - strong 또는 b : 볼드체
        - em : 이탤릭체
        - mark : 형광펜 효과
        - small, sub, sup : 글자 작게, 아래첨자, 윗첨자
        - u, strike : 밑줄, 취소선
        - a : 웹페이지 링크(중요!)
        - ul, ol > li : 순번 없는 목록, 순번 있는 목록
        - table, tr, th, td: 테이블 만드는 태그
        - audio, video : 오디오, 비디오
        - object, embed : 객체 추가
    
    - HTML + CSS + Javascript
        - 내부 스타일, 외부 스타일, 인라인 스타일
        - 내부 스크립트, 외부 스크립트, 인라인 스크립트

    - 오류, 디버그
        - F12 개발자도구로 활용

    - 양식태그(body > form 안에 사용 필수)
        - front-end 입력한 내용이 back-end로 보내기 위한 관문
        - form을 반드시 사용
        - input
            - type='text' : 텍스트박스
            - type='password' : 비밀번호박스
            - type='button' : 일반 버튼
            - type='submit' : 제출(!)
            - checkbox : 체크박스
            - radio : 라디오 버튼
            - file : 파일 업로드
            - image : 이미지(img와 유사)
            - reset : 폼 내의 입력양식태그 값 초기화
            - hidden : 숨김값(유용하게 사용!!!)
        - textarea: 여러 행 텍스트 입력
        - select : 콤보박스
        - fieldset : 그룹박스
        - submit 클릭 loopback(값 전달) 발생
        - 값 전달 방법
            - GET : URL뒤 ?다음에 key=value&key=value ... 데이터 전달
            - POST : 화면 뒤로 숨겨서 데이터 전달 방식
        
        - 공간구분 태그
            - span - 한 줄로 공간구성
            - div - 행간으로 블록지정 공간구성

## 2일차
- HTML5
    - 시맨틱 태그 - 시맨틱 태그로 화면 구조를 잡는 웹구성 방식
        - header, main, content, nav, footer, aside, section, article... 구조 태그(화면에 안 나타남) 사용
        - 시맨틱 태그를 div로 바꿔도 똑같이 동작하기때문에 요새는 많이 사용 안 함. 걷어내고 있는 추세
- CSS3
    - 웹 디자인 핵심, Casting Style Sheets
    - 상단에서부터 <body>부터 하위의 태그들에 계속해서 적용되는 스타일이라는 뜻
    - 선택자에게 주어지는 디자인 속성
    - 선택자(selector)
    - 속성(property)
    - 배경, 폰트 ...
    - 레이아웃
        - HTML만으로는 화면 레이아웃이 만들어지지 않음
        - 중앙정렬, 원트루, 고정바 ...
    - 반응형 웹(Responsive Web)
        - 메타태그 viewport를 사용하면 그때부터 반응형 웹이 됨!
        ```html
        <meta name='viewport' content='width=device-width, initial-scale=1'>
        ```
        - @media 태그 : 디바이스 종류별로 CSS 따로 디자인 가능

## 3일차
- Javascript
    - 스크립트 언어, ECMAScript
        - 웹 브라우저에서 주로 사용
        - 바닐라 스크립트 : 완벽하게 기본에 충실한 자바 스크립트
        - 기본적으로 클라이언트(웹 브라우저에서 프론트엔드에 표시) 베이스
        - Node.js : 자바스크립트로 백엔드를 구현
        - 특징
            - 자료형 선언이 없음. var 변수 선언
            - 인터프리터 언어(not Compile Language)
            - 확장자 .js
            - 속도가 컴파일 언어에 비해서 느림
            - VS Code도 자바스크립트로 만든 앱
            - 문장 끝 ; 은 생략가능, but 최대한 쓸 것
            - 변수 선언시 let(일반), var(지역변수), const(상수)
            - HTML 태그와 연계(DOM) 중요!!!
            
        - 기본 용어
            - 표현식 : 값을 만들어 내는 간단한 코드
            - 문장 : 프로그래밍 언어에 실행할 수 있는 코드의 최소 단위
            - 종결 : 문장 마지막에 세미콜론(;) 또는 줄 바꿈
            - 키워드 : 자바스크립트를 처음 만들 때 정해진 특별한 의미가 부여된 단어
            - 식별자 : 자바스크립트에서 변수나 함수 등에 이름을 붙일 때 사용하는 단어
                - 키워드 사용 불가
                - 특수문자는 _와 $만 허용
                - 숫자로 시작하면 안됨
                - 공백 입력 불가

        - 자료형
            - 숫자 : 가장 기본적인 자료형, 정수와 실수를 구분하지 않음, 0으로 나눠도 예외가 발생하지 않음
            - 문자열 : 파이썬과 동일하게 '와 " 모두 사용
            - 불(bool) : 참과 거짓을 표현할 때 사용하는 자료
            - 비교 연산자 : 두 대상을 비교할 수 있는 연산자
                - 완전히 동일함과 비교하는 === 연산자
            - 논리 연산자
            - 변수 : 값을 저장할 때 사용하는 식별자

        - 함수의 선언과 호출
            - 함수 : 코드 집합을 나타내는 자료형
            - 익명 함수 생성 : 함수 이름을 입력하지 않고 만들기
            ```html
            let fn1 = function() {
                console.log('함수 fn1 실행!');
                console.log('함수종료!!');
            }
            console.log('변수타입 = ' + typeof(fn1));
            fn1();
            ```
            - 선언적 함수 생성 : 함수 이름을 입력해서 만들기
            ```html
            function fn2() {
                console.log('함수 fn2 실행!');
                console.log('함수 fn2 종료!!');
            }
            console.log('변수타입 = ' + typeof(fn2));
            fn2();
            ```
            - **익명함수가 선언적 함수보다 우선순위가 높다**
            - 콜백 함수
                - 매개변수로 전달되는 함수
            - 요소 : 배열에 있는 값 하나하나
            - 속성 : 객체에 있는 값 하나하나
        
        - this 키워드
            - 객체에 있는 속성을 메서드에서 사용하고 싶을 때는 자신이 가진 속성임을 분명하게 표시해야 함

        - DOM(Document Object Model : 문서 객체)!!!!
            - 태그를 자바스크립트에서 사용할 수 있는 객체로 만든 것
            - 문서 객체를 조작한다는 말은 결국 태그를 조작한다는 의미
            - 실행 순서!
            - HTML에 있는 모든 요소를 제어할 수 있음
            - html 애니메이션, 게임, 통신 모두 가능
            - 이벤트 on- 으로 시작
                - onload : 화면이 다 렌더링되면 그 다음 발생
                - onfocus : 객체에 마우스를 클릭해서 포커스가 가면 발생
                - onclick : 객체를 마우스로 클릭하면 발생
                - ondbclick : 더블클릭
                - onmousemove: 마우스를 이동하면 발생
                - onmouseover : 객체 위에 마우스가 올라가면 발생
                - onkeydown, onkeypress : 객체에서 키보드를 타이핑하면 발생
            
            - jQuery
                - 자바스크립트 라이브러리
                - js를 매우 편리하게 사용할 수 있도록 도와주는 서포트 라이브러리
                - 순식간에 웹개발 업계를 장악했던 라이브러리
                - 사용빈도가 줄고는 있지만 아직도 80% 웹 사이트가 사용 중
                - js 파일 다운로드 후 사용하거나
                - CDN 링크를 사용하는 방법(추천!)

## 4일차
- HTML + CSS + js(jQuery) 응용
    - jQuery 응용
        - javascript와 jQuery를 혼용해도 상관없음
        - jQuery로 코딩 편할 때와 javascript가 편할 때도 있음

    - Bootstrap
        - 오픈소스 CSS 프레임워크
        - 트위터 블루프린트 -> 부트스트랩
        - 현재 전 세계에서 가장 각광받는 프레임워크 중 하나
        - CSS를 동작시키기 위해서는 Javascript도 포함
        - 소스 다운로드 받아서 사용(1), CDN으로 링크만 사용(2). 
            - 제한된 네트워크에서는 (1)
            - 인터넷에 항상 연결된 환경에서는 (2)가 훨씬 편리
        - 핵심!
            - Bootstrap은 화면사이즈를 12등분!
                - 12를 넘어서면 디자인이 깨짐!!!
            - container 및에 마치 table처럼 div를 구분해서 사용
            - container > row > col div 태그 클래스 정의
            - 부트스트랩 학습에 시간을 들이는 게 아님. Copyleft가 정석!
                - https://getbootstrap.com/docs/5.3/getting-started/introduction/ 참조
                - https://getbootstrap.com/docs/5.3/examples/ 스니펫 활용 추천
            - 무료 테마(템플릿)가 아주 잘 되어 있음
                - https://startbootstrap.com/

        - 웹 페이지 클로닝
            - 핀터레스트 타입 + 부트스트랩 웹 페이지 만들기(진행중)

## 5일차
- HTML + CSS + js(jQuery) 응용
    - 웹 페이지 클로닝
        - 핀터레스트 타입 + 부트스트랩 웹 페이지 만들기(완료)


        https://github.com/LEUNSU/basic-aspnet-2024/assets/158007401/15cd730f-defa-47c0-9b77-63f5ef8f9923


        - Codehal 유튜버 로그인 웹 페이지 튜토리얼 따라하기

        <img src="https://raw.githubusercontent.com/LEUNSU/basic-aspnet-2024/main/images/an0001.png" width="800">
        <!-- ![이미지](https://raw.githubusercontent.com/LEUNSU/basic-aspnet-2024/main/images/an0001.png) -->


        - Codegal 슬라이더 애니메이션 웹 페이지 튜토리얼 따라하기

## 6일차
- HTML + CSS + js(jQuery) 응용
    - 웹 페이지 클로닝
        - Codegal 슬라이더 애니메이션 웹 페이지 튜토리얼 따라하기(완료)


        https://github.com/LEUNSU/basic-aspnet-2024/assets/158007401/0f655e0b-de21-47dd-8921-65a8c76d546b


    - 개인 웹 페이지 클로닝(유튜브 애니메이션 웹 페이지 튜토리얼 따라하기)


        https://github.com/LEUNSU/basic-aspnet-2024/assets/158007401/2e54f5f6-ce14-4c3e-8587-77c463a25762


## 7일차
- HTML + CSS + js(jQuery) 응용
    - 개인 웹 페이지 클로닝(유튜브 애니메이션 웹 페이지 튜토리얼 따라하기)

    
        https://github.com/LEUNSU/basic-aspnet-2024/assets/158007401/4cd981f1-69e9-4705-bc11-8f45f9c016d6


## 8일차
- ASP.NET 
    - ASP.NET 역사
        - 1990년대 MS가 웹 서버기술로 ASP(Active Server Page)를 배포 like JSP(Java Server Page)
        - ASP는 .NET으로 된 언어가 아닌, VBScript를 사용. 확장자(.asp)
        - 스파게티 코드! - HTML + CSS + javascript + VBscript 짬뽕으로 만든 웹 페이지
        - 많이 사용되었지만 유지보수 어렵고, 성능이 나쁘고 ...

        - 2000년대 MS가 .NET Framework를 발표
        - C#, VB.NET, C++.NET 등의 새로운 언어를 배포, 여기에 맞춰서 웹 서버기술로 다시 만듦 -> ASP.NET
        - 가장 큰 장점은 윈폼 개발하는 것처럼 웹 개발을 할 수 있었음
        - 초창기에 스파게티 코드를 거의 그대로 사용. 성능도 안 좋고 ...
        - 2009년 ASP.NET MVC(Model View Controller 디자인패턴) 공표. 성능은 좋아짐
        - 하지만, 윈도우에서만 동작
        - 모든 OS플랫폼에서 동작할 수 있는 .NET Core를 재출시
        - 거기에 웹 서버기술을 또 다시 만듦 => ASP.NET Core

    - .NET Core(현재는 .NET 9.0, Core라는 이름은 사용 안 함)의 장점
        - 빠르고 오픈소스
        - 크로스 플랫폼, OS에 종속받지 않음
        - 성능!
    
    - ASP.NET 종류
        - ~~ASP.NET Webforms - 2000년도 초반에 나오다가 사장된 웹 사이트 개발 기술~~
        - **ASP.NET Core 웹 API : 데이터 포털, 네이버, 카카오, 영화API 사이트를 만드는 백엔드(프론트엔드가 없어서 화면이 없음)**
        - **ASP.NET Core 웹앱(MVC) : 가장 기본적인 프론트엔드(HTML, CSS, JS .cshtml) + 백엔드(C# .aspx.cs) 웹 사이트 개발**
        - Js(Vue, Anguler, React) 프론트엔드 + ASP.NET Core 백엔드
        - ~~Edge용 웹 드라이버 테스트 - 엣지 브라우저에 종속된 테스트용~~
        - ASP.NET Core gRPC 서비스 - 고성능 원격프로시저호출(스트리밍 호출) 서비스 
        - Blazor : Js 프론트엔드를 따라서 C# 컴포넌트 기반으로 개발하는 웹 개발 방식 웹 사이트 개발
        - Razor : 프론트엔드 개발에 C# 코드가 특화되서 사용되는 웹 사이트 개발 방식
        - .NET Aspire : Blazor + Redis + 웹 API 백엔드

    - 참조 사이트
        - https://learn.microsoft.com/ko-kr/aspnet/core/?view=aspnetcore-3.1
        - https://github.com/dotnet
        - https://mixedcode.com/
        - https://github.com/gilbutITbook/006824

    - ASP.NET Core 웹 앱(Model-View-Controller)
        - 현재 기본적인 웹 개발의 가장 표준
        - Java 계열도 Spring (Boot) MVC로 개발
        - MVC 개념도
            <IMG src="https://raw.githubusercontent.com/LEUNSU/basic-aspnet-2024/main/images/an0002.png">

        - 프론트엔드가 예전엔 스파게티코드가 무지 심했다면, 현재는 스파게티코드가 최소화 되어있음(SpringBoot, Python flask는 모두 동일)
        - IIS Express Server - VS에서 ASP.NET 웹 사이트를 운영하는 개발용 웹 서버
        - index.* : 웹 사이트 가장 대문이 되는 페이지 이름
        - 파일 저장시 핫다시로드(HotReload) 체크
        - @로 시작하는 C# 구문, Tag helper, Html helper로 HTML 구문 내에 C# 코드를 적어서 활용하는 방법 = Razor 구문
        - Action == HTML에서 Form 태그 내 submit 버튼 클릭! / 링크를 클릭하는 것, 윈 앱에서 이벤트와 동일
        - 액션이 발생한 이후 처리하는 메서드의 결과를 ActionResult
        - 콘솔 서버로그 잘 확인할 것, 프로세스가 종료되면 웹 사이트가 실행 안 됨
    
    - 데이터베이스 연동방법
        - DB first - 가장 전통적인 DB 연동방식. DB설계, DB구축, C#과 연동
        - Code first - 최근 트렌드가 되는 DB 연동방식. C# 엔티티 클래스 작성, DB연결 설정 후 실행하면 DB에 테이블이 생성...
        - EntityFramework를 사용하면 아주 손쉽게 구축 가능. DB를 잘 모르고 C#, ASP.NET만 알아도 DB를 핸들링 가능

    - EntityFramework(Core) 설치
        - Microsoft.EntityFrameworkCore
        - Microsoft.EntityFrameworkCore.Tools
        - Microsoft.EntityFrameworkCore.SqlServer
    
    - Code first 구현 순서
        - ASP.NET 프로젝트 생성
        - EF 패키지 설치
        - 엔티티 클래스 작성
        - appsettings.json에 DB연결문자열 추가
        - Data/ApplicationDbContext.cs 중간연결 클래스 생성
        - Program.cs에 Service 내에 DbContext 종속성을 주입
        - NuGet 패키지 관리자 > 패키지 관리자 콘솔 실행 
            ```shell
            PM> Add-Migration 마이그레이션명
            Build started...
            Build succeeded.
            ...
            PM> Update-Database
            ...
            Done.
            ```
## 9일차
- ASP.NET Core MVC
    - 필요 이론
    - 연습
    - 개인 포트폴리오 웹 사이트
    - Bootstrap 테마 적용