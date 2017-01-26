# dotnet-remoting

-. .Net Framework에서 제공하는 서버-클라이언트 간 통신 기술인 Remoting을 사용한 프로젝트.

-. 사용법

	(1). Remoting-Server 프로젝트 빌드 및 실행.
	
	(2). Remoting-Client 프로젝트 빌드 및 실행.
	
	(3). 화면에 출력된 윈도우 프로그램(User-Management) 확인.
	
	(4). 'Management' 메뉴 클릭.
	
	(5). 'add User' 메뉴 클릭.
	
	(6). NAME, POSITION, AGE, SEX 항목 입력 후 'regist user' 버튼 클릭.
	
-. 사용 기술

	(1). C# WinForm.
	
	(2). delegate, event 를 사용한 콜백.
	
	(3). .Net Remoting.
	
	(4). .Net Reflection.
	
	(5). MVC 패턴 구조.
	
	(6). Singleton 생성 패턴.
	
-. 각 프로젝트 설명.

	(1). Remoting-Server : .Net Remoting 서버의 EndPoint 등록 및 서버 실행.
	
	(2). Controller : 클라이언트의 Request를 최상단에서 받으며, 클라이언트에게 프락시 개체 형태의 라이브러리로 제공. (일반적인 Controller 역할.)
	
	(3). Service : Controller에서 호출하며, 실제적인 비지니스 로직을 수행.
	
	(4). Dao : 데이터 액세스에 대한 처리를 담당하여 수행.
	
	(5). Database : 실제로 데이터를 보관, 핸들링 역할 수행.
	
	(6). Model : 서버-클라이언트 또는 서버 내부에서 데이터를 주고 받기위해 사용되는 사용자 정의 모델.
	
	(7). Remorting-Client : .Net Remoting 서버에 요청하고, 데이터를 가시화. (테스트용)