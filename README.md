# Game programming patterns in Unity
일반적으로 게임을 만들기 시작할 때, 직면하는 어려움을 해결하기 위한 모범사례이기에 Unity 프로젝트를 잘 구성하기 위해선 유용한 정보 입니다. 하지만, 다양한 방법 중의 하나이기에 문제를 해결하기 위한 단순한 도구로 보아야 하며 반드시 사용할 필요는 없습니다. 업데이트, 루프, 컴포넌트 와 같은 일부 패턴은 이미 Unity에 내장되어 있으므로 이미 사용되고 있습니다.

프로그래밍 패턴은 다음 그룹으로 나눌 수 있습니다.

* Architectural patterns - 한예로 MVC(Model-View-Controller)가 있습니다.
* Design patterns - 아키텍처 패턴보다 더 구체적인 것으로 Singleton이 해당 사례 입니다.
* Anti-patterns - 비효율, 비생산적이지만 문제 해결을 위해 프로그래머들이 사용하게 되는 패턴 모음입니다. 사례로 GameController가 게임 구동에 관한 모든 것을 관리하는 것 입니다. 유지관리 측면과 디버깅의 어려움으로 연관됩니다.

## 1. Observer
게임에선 다양한 일이 끊임없이 발생하며 이를 이벤트 또는 메세지 라고 하며, 이러한 이벤트 시점에 특정 함수가 실행되어야 하는지 파악하기 위해 발생 시점에 표시를 해두고 해당 표시를 subscribe / unsubscribe 를 통한 느슨한 결합으로 연결합니다. 이는 상호 의존성을 최소화 할 수 있기에 유연한 객체지향 시스템을 구축할 수 있습니다.

### 구현 방법
유명한 패턴이기에 C#과 Unity에서 이를 활용할 수 있도록 아래와 같이 내장되어 있습니다.
* event handler
* Action
* UnityEvent
* delegate를 통한 자체 구현

### 관련 패턴
* Event Queue
* Model-View-Controller (MVC)

## 2. Singleton