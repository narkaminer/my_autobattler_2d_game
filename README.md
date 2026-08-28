# my_autobattler_2d_game
A mobile 2D autobattler combining simple real-time battles with RPG-style progression and unit evolution.
# 2D Autobattler

A mobile 2D autobattler combining simple real-time battles with RPG-style progression and unit evolution.

The goal is to create a simple, accessible and satisfying game that is easy to understand but offers long-term progression through unit upgrades, profile progression, evolutions, abilities and rewards.

> **Status:** Early Development

## 🎮 Core Concept

The player builds an army by spending gold to deploy different types of units.

Units automatically move across the battlefield, fight enemy units and eventually attempt to destroy the enemy throne.

A typical battle follows this flow:

```text
Choose Units
     ↓
Spend Gold
     ↓
Deploy Units
     ↓
Automatic Battle
     ↓
Defeat Enemy Army
     ↓
Destroy Enemy Throne
     ↓
Victory & Rewards
```

## ⚔️ Current Features

The current prototype includes:

* 2D battlefield
* Player and enemy sides
* Unit spawning system
* ScriptableObject-based unit data
* Melee and ranged attack types
* Projectile system
* Unit health system
* Health bars
* Automatic unit movement
* Automatic combat
* Enemy targeting
* Battle win / loss / draw detection
* Throne-based battle objectives
* Separate unit prefabs
* Modular unit components

## 🧙 Planned Units

The game is planned to feature multiple unit classes, including:

* Swordsman
* Archer
* Mage
* Tank
* Healer
* Assassin
* Shaman
* Recruiter
* Kamikaze / Explosive Unit

More unit types may be added during development.

## 🧬 Unit Evolution

Units will eventually be able to evolve into more advanced forms.

For example:

```text
Swordsman
    ↓
Ninja
    ↓
Advanced Fighter
```

And:

```text
Archer
    ↓
Gunslinger
    ↓
Sniper
```

Evolution will be unlocked after reaching specific progression requirements.

## 📈 RPG Progression

The game will include a persistent player profile with individual progression for each unit type.

Planned upgrade categories include:

* Health
* Damage
* Attack Speed
* Movement Speed
* Passive Gold Generation
* Kill Rewards
* XP Gain
* Base Health

Profile progression will remain active across battles.

## 💰 Economy

The game is planned around several types of resources.

### Gold

Gold is the main in-battle currency.

Planned sources include:

* Passive gold generation
* Enemy kills
* Other battle rewards

Gold is primarily used to deploy units during a battle.

### Diamonds

Diamonds will be a premium currency used for future monetization features and special rewards.

### XP

XP is a persistent progression resource.

Players will earn XP from various activities, including:

* Playing battles
* Defeating enemies
* Completing levels
* Achievements
* Daily activity
* Optional rewarded advertisements

XP will be used to upgrade the player's profile and unlock additional progression.

## 🗺️ Level Structure

Levels will consist of multiple enemy waves.

A typical level may contain:

* Wave 1
* Wave 2
* Wave 3
* Boss / special wave

Enemy compositions, unit types and difficulty will be designed individually for each level rather than relying entirely on automatic scaling.

The goal is to keep levels varied and prevent the game from feeling like an endless numerical treadmill.

## ✨ Future Features

Planned features include:

* More unit classes
* Unit evolution system
* Multiple enemy types
* Boss battles
* Player abilities / magic
* Fireball
* Lightning
* Poison / smoke
* Blood magic
* Temporary stat boosts
* Achievements
* Profile progression
* Rewarded advertisements
* Battle Pass
* Premium currency
* Skill redistribution items
* More detailed level design
* Mobile UI and touch controls
* Audio and visual effects
* Improved animations

## 🛠️ Technology

Built with:

* **Unity**
* **C#**
* **Unity 2D**
* **ScriptableObjects**

## 📁 Project Structure

```text
Assets/
├── Materials/
├── Scenes/
│   └── Prefabs/
├── ScriptableObjects/
├── Scripts/
├── Settings/
├── Sprites/
└── UI/
```

## 🚧 Development Status

This project is currently in early development.

The core combat prototype is functional, but many systems are still being designed and implemented.

Architecture and gameplay systems may change significantly during development.

## 🎯 Long-Term Goal

The long-term goal is to release the game on:

* Google Play
* Apple App Store

The project is being designed primarily for mobile devices, with a focus on:

* Simple controls
* Short battles
* Clear progression
* Satisfying feedback
* Accessible gameplay
* Long-term player progression

## 📜 License

Copyright © 2026. All rights reserved.

This repository is provided for viewing and development purposes only.

Unless explicitly permitted by the copyright holder, the source code, assets, designs and other original materials in this repository may not be copied, modified, redistributed, sublicensed or used in other projects, including commercial projects.

The project is currently proprietary and does not grant permission for reuse of its code or assets.

---

*This README describes the current direction of the project and may change as development continues.*
