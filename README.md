# Yet Another Dungeon Crawler

Authors: Breno Pinto, Martim Vicente

##Description:
"Yet Another Dungeon Crawler" is a text-based dungeon crawler game implemented in C#. The game allows players to navigate through various rooms within a dungeon, encountering enemies and items along the way. Players can engage in combat with enemies, pick up items, use consumables, and manage their inventory.

The organization of the code is:
There is base classes made by Breno such as ItemBase, Weapon, Consumable and Enemy.
This classes is used to organize things.
There is the Map and rooms made by Martim
The controller, View, Item types and Enemy types made by both.

##  UML Diagram
```mermaid
classDiagram
    class ItemBase {
        <<abstract>>
        Level
    }

    class Weapon {
        <<abstract>>
        IsEquiped
        Equip()
        AttackBuff
    }

    class Consumable {
        <<abstract>>
        Use(Player)
    }

    class Enemy {
        <<abstract>>
        HP
        AttackPower
        BIsDead
        Damage()
        Attack()
    }

    class HealPotion {
        Level
        healAmount
        Use()
        ToString()
    }

    class WoodenSword {
        IsEquiped
        Level
        AttackBuff
        Equip()
        ToString()
    }

    class Zombie {
        BIsDead
        HP
        AttackPower
        ToString()
    }

    class ItemBase <|-- Consumable
    class ItemBase <|-- Weapon
    class Enemy <|-- Zombie
    Consumable <|.. HealPotion
    Weapon <|.. WoodenSword
```
