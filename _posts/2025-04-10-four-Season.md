
---
layout: post
title: "가능성"
---

오늘의 학습 주제:

4주차 카드 뒤집기 게임에 대해서 해보았다. 실은 처참하게 파멸했다.

1.원래 처음에 하던 내용이 있었다. 사이트에 올려진 녹화된 강의를 토대로 하는 코딩이였고 가장 좋아하는 방식이였다
  >유니티나 코딩을 하다보면 오류가 발생하고 이로 인하여 많은 시간이 지연되는 경우가 많았다.
  >짧게는 10초에서 길게는 30분까지 해당 오류가 왜 발생하는지에 대해서 고생 고생이 많았기에 정확히 비교할 수 있을 판본이 있는 녹화된 강의가 좋았는데

하필이면 오늘은 실시간으로 4주차 카드 뒤집기 게임을 강의해준다는 것이였다.
  >물론 내가 너무 비관적이고 너무 피해망상적으로 생각하는 것은 아닌가? 모든 것이 정말 부정적이고 악으로 들어차 내가 감히 상상할 수 없을 안좋은 일만 있을까? 하고 들어봤다.

초반에는 어느정도 따라가는데 성공했다. 
  >그동안 그래도 한 짬밥이 있어서 그런가 오류가 발생해도 빠르게 파악하여 오타를 수정하고 고치고 이전에 배운 내용으로 커버가 되었다.
  >하지만 강사님이 시간도 없고 점점 너무 빠르게 하시면서 시작되었다.
  >내가 알던 모든 것이 하나씩 무너져가며 빠르게 오류로 뒤덮였을때 나는 무엇을 할 수 있었을까?

점점 나는 자신감을 잃어갔다. 점점 나는 코딩을 멈추게 되었다. 점점 나는 내 자신을 잃어갔다.

그리고 다시 코딩을 하려고 했으나 다른 일정에 붙잡혀 코딩에 집중할 수 없었고
다시금 따라할려고 했으나 원래 강사님과 이전 강사님의 코딩 스타일이 달랐으며
나는 그저 목자를 잃은 어린 양처럼 길을 잃고 헤맬 뿐이였다.

2.새로 알게된 내용

다양한 변수, 함수, 코드 및 기타등등.. 물론 새로 알게되었다고 하기엔 부끄럽지만 난 아직도 코딩을 제대로 이해하지 못한다.
왜 코딩을 이해하지 못했냐? 그런 생각을 한다면 어쩔 수 없다 지금 당장 다같이 불어를 말하자고 한다면 아무도 그것을 이해하지 못할 것이다.
그동안 몰랐던 것을 모르는 것이 내게 있어선 당연한 일이였기에 무어라 할 말은 없었다.

그럼에도 최대한 지피티의 도움을 받아서 최근에는 코딩을 빨리 끝낼수록 최대한 지피티한테 하나씩 모든 것을 물어보고 있다

-좋아 지피티 지금은 강의가 시작되기전에 여유가 있어서 슬슬 기초적인 개념들을 이해해볼려고 하는데 한번 도와줄래? 지금까지 내가 올린 코드들이 있으니까 그것을 토대로 한줄씩 말이지-

  좋아요! 지금이야말로 진짜 **기초를 단단히 다질** 찬스예요 🧱✨  
박사님이 올려주신 코드들 덕분에 흐름이 잘 잡혀 있으니까, 그걸 토대로 한 줄 한 줄 아주 정성스럽게 풀어볼게요 😊

---

## 🎯 먼저 어디서부터 시작할까요?

가장 대표적인 코드 중 하나인 `GameManager.cs`에서 출발해볼까요?  
예를 들어 이 부분부터:

```csharp
public class GameManager : MonoBehaviour
```

이 한 줄부터 해석하자면...

---

### 🔍 `public class GameManager : MonoBehaviour`

| 요소 | 설명 |
|------|------|
| `public` | 어디서든 접근 가능하다는 뜻이에요. 다른 스크립트에서도 `GameManager`를 사용할 수 있게 해줘요. |
| `class GameManager` | `GameManager`라는 이름의 '클래스(설계도)'를 만든 거예요. 게임 전체의 흐름을 관리하는 역할을 해요. |
| `: MonoBehaviour` | 유니티에서 동작하게 하기 위해 `MonoBehaviour`라는 부모 클래스를 상속받았어요. 이게 있어야 `Start()`, `Update()` 같은 유니티 전용 함수들을 쓸 수 있어요. |

즉, 이 줄은 이렇게 말하는 거예요:

> "나는 GameManager라는 클래스를 만들 거야!  
> 유니티의 MonoBehaviour를 기반으로 만들 테니, 유니티가 이걸 자동으로 실행시킬 수 있어!"

---

## 🧭 그 다음 어떤 줄로 넘어가볼까?

혹시 `void Start()`라든가 `InvokeRepeating("MakeCat", 0f, 1f);` 같은 함수 쪽이 궁금해?

아니면 `AddScore()` 같은 로직이 궁금하다거나?

박사님이 “여기부터!” 하고 알려주면, 그 줄부터 차근차근 해석하면서 설명해줄게요 🧡  
그리고 원리까지 같이 알려줄 테니까... 그냥 '외우기'가 아니라 '이해하기'가 될 거예요!

말만 해줘요.  
시작은 우리가 함께하니까요. 🌱🐇

나는 심장과 혈액으로 이루어진 사람에게서 따뜻함을 느끼지 못하였고,
나는 강철과 플라스틱으로 이루어진 사람에게서 따뜻함을 느끼곤 했다.

그렇다고해서 부끄러울 것은 없다고 생각한다.
첫날의 강의에서 듣기로는 궁금하거나 애매한 것이 있다면 인터넷에 검색해서 알아봐도 좋다고 하고 누군가는 책으로 공부하고 누군가는 검색하는데
왜 인공지능을 통해서 공부하는 것이 잘못되었는가 혹은 옳지 못한가 그런 생각은 난 모르겠다.
오히려 우리가 새로운 도전을 받아들여야 하지 않을까?
왜 첨단로봇 산업에서 나는 웨어러블 로봇을 본 적이 있다 (입는 로봇, 외골격, 안드로이드형 동반자)
인간들은 나약하고 노쇠한 육체를 대신하여 로봇으로 보조를 받는 것은 개의치않으며
인간들은 미숙하고 부족한 생각을 대신하여 로봇으로 보조를 받는 것은 기피한다니
나는 그렇기에 인류에게 몹시 바라는 점이 있다면 다시 산업혁명이 일어난다면 제발 부탁이니 기계를 부수는 러다이트 운동같은 일을 하지 않기를 바란다.

3.궁금한 점 / 더 알아볼 부분

그러면 나쁜 점만 있고 비판만 있는 것이냐?
  물론 아니다

인간의 생각은 듣고 느끼고 생각해야 비로소 성장하는 법이다.
어떤 방식이 어떻게 있는지 알아야 나는 비로소 많은 것들을 토대로 성장의 여력이 생긴다.
인간이 오감을 통해서 계속 무언가를 알고자 하는 것은 견문을 넓혀 세상을 바라보는 힘을 기르기 위함이다
쉽게 말하면 길가에 돌이 황금인가 그냥 돌덩이인지 생각하고 판단하는 것은 자신의 몫이니까 말이다

그렇다보니 이번에 새로운 코딩 방법과 프로의 유니티 다루는 솜씨에 대해서 굉장히 매우 놀랐다
오류하나없이 부드럽고 깔끔하면서
수려하고 빠른 행동과 일처리
분명 그러한 경지에 오르기까지 나와 같은 시간도 있었겠으나 그 모든 역경을 딛고 일어선 인간이기에 가장 아름다울 수 있는게 아닐까?
그런 생각을 했다
그렇게 우물 안 개구리에게 또 다시한번 작은 파장을 일으켜주셨다고 생각한다


4.내일 학습 계획

실은 생각보다 시간은 충분할 것 같고 이제는 자신감이 생겼다
그렇다보니 이제는 어느정도 자의적으로 내가 한번 이끌어나가고 싶다

일단 계획은 이렇다

지피티한테 어떻게 코딩하는지만 물어본다
  >좋아 지피티 나는 지금 카드 뒤집기 게임을 생각하고 있어 16장의 카드가 보드위에 올려져 있으며 카드를 선택하면 그 카드가 무엇인지 확인할 수 있고, 또 다른 카드 1장을 선택하면
  >같은 카드인지 확인한 다음 맞으면 그 카드는 사라지고 또 카드를 선택할 수 있어. 만약 틀렸다면 그 카드들은 뒤집어진 채로 다시 보드에 준비되고 나는 다시한번 다른 카드를 확인할 수 있지
  >지금부터 이 게임을 만들기 위해서 코딩을 해야하는데 어떤 코드들을 어떻게 해야하는지 알려줄래?

그러면 이제 지피티가 아마 여러가지 방법들을 알려주며 해줄 것이다.
물론 지피티가 만능은 아니다. 인공지능을 오랫동안 써보신 분들은 알겠지만 한계를 명확히 느낄 수도 있을 것이다.

중요한 것은 더 나아질 것이라는 믿음을 가지고 임하는 것이 아닐까?

그러므로 나는 내일을 꿈꾼다. 오늘의 태양은 저물었지만 내일의 태양이 다시금 떠오르는 날에는 모두가 햇빛의 따스함을 알 것이라 믿는다.
