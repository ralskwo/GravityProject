# Unity 중력 시스템: 맞바람과 블랙홀 물리 효과 구현

이 프로젝트는 Unity에서 중력 시스템을 활용하여 다양한 물리 효과를 구현하는 예제를 제공합니다. 기본 중력 설정부터 맞바람 효과, 사용자 정의 중력 필드, 그리고 블랙홀 효과까지 다양한 사례를 다루고 있습니다. 이 프로젝트를 통해 중력과 물리 엔진을 활용하여 게임플레이에 깊이를 더하는 방법을 학습할 수 있습니다.

## 프로젝트 개요

- **주요 기능**
  - **기본 중력 및 점프 시스템**: 기본적인 중력 환경에서 캐릭터의 점프와 낙하를 제어합니다.
  - **맞바람 시스템**: 특정 영역 내에서 바람의 방향과 세기를 설정하여, 바람에 의해 물체가 밀리는 효과를 구현합니다.
  - **사용자 정의 중력 필드**: 특정 영역에서 오브젝트가 다른 중력 방향으로 움직이도록 설정하여, 다양한 중력 환경을 시뮬레이션합니다.
  - **블랙홀 효과**: 거리에 따라 중력이 강해지며, 물체를 중심으로 끌어당기는 블랙홀 효과를 구현합니다. 블랙홀 근처로 접근할수록 중력이 강해져 오브젝트가 빨려들어갑니다.

## 설치 및 사용 방법

1. **프로젝트 클론**

```bash
git clone [repository_url]
cd [project_folder]
```

2. **Unity에서 프로젝트 열기**: Unity 허브를 사용해 해당 폴더를 열어 프로젝트를 실행합니다.
3. **씬 설정**: 각 스크립트에 맞는 오브젝트를 생성하고, `WindSystem`, `BlackHole`, `CustomGravityField` 등의 스크립트를 적절한 오브젝트에 추가합니다.
4. **파라미터 조정**: Inspector 창에서 각 스크립트의 파라미터를 조정하여 맞바람의 세기, 블랙홀 중력의 강도 등을 설정할 수 있습니다.

## 주요 스크립트 설명

- **PlayerController.cs**: 기본적인 점프 및 이중 점프 기능을 구현한 스크립트입니다. 플레이어의 점프력과 최대 점프 횟수를 설정할 수 있습니다.
- **WindSystem.cs**: 바람의 방향과 세기를 설정하고, 특정 트리거 영역 안에 있는 물체에 바람의 힘을 적용합니다.
- **WallWalkController.cs**: 중력의 방향을 벽 표면을 향하게 하여 캐릭터가 벽을 걸을 수 있도록 합니다.
- **CustomGravityField.cs**: 특정 영역에서 중력 방향을 조정하여 다양한 중력 환경을 시뮬레이션합니다. 예를 들어, 행성 중심을 향한 중력을 적용할 수 있습니다.
- **BlackHole.cs**: 블랙홀의 중력을 구현하며, 거리에 따라 중력의 세기가 강해지고, 가까이 다가간 오브젝트를 중심으로 끌어당깁니다.

## 학습 포인트

- Unity의 물리 엔진을 활용한 중력 시스템 구현 방법
- 물리 기반 오브젝트 제어 및 맞바람, 중력 필드 설정
- 고유한 물리 환경을 사용한 게임플레이 확장
