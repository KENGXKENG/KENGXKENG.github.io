﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SpartaDungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            Character player = new Character("Chad", "전사", 1, 10, 5, 100, 1500);
            List<Item> shopItems = InitializeShop();

            while (true)
            {
                ShowMainMenu();
                string input = Console.ReadLine();
                if (input == "1")
                    ShowStatus(player);
                else if (input == "2")
                    ShowInventory(player);
                else if (input == "3")
                    ShowShop(player, shopItems);
                else
                    Console.WriteLine("잘못된 입력입니다\n");
            }
        }

        static void ShowMainMenu()
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n");
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점\n");
            Console.Write("원하시는 행동을 입력해주세요.\n>> ");
        }

        static void ShowStatus(Character player)
        {
            Console.WriteLine("\n상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.\n");
            Console.WriteLine($"Lv. {player.Level:00}      ");
            Console.WriteLine($"{player.Name} ( {player.Job} )");
            int atkBonus = player.Equipped.Sum(i => i.AttackBonus);
            int defBonus = player.Equipped.Sum(i => i.DefenseBonus);
            Console.WriteLine($"공격력 : {player.BaseAttack + atkBonus}" + (atkBonus > 0 ? $" (+{atkBonus})" : ""));
            Console.WriteLine($"방어력 : {player.BaseDefense + defBonus}" + (defBonus > 0 ? $" (+{defBonus})" : ""));
            Console.WriteLine($"체    력 : {player.Health}");
            Console.WriteLine($"Gold : {player.Gold} G\n");
            Console.WriteLine("0. 나가기");
            Console.Write("원하시는 행동을 입력해주세요.\n>> ");
            Console.ReadLine();
        }

        static void ShowInventory(Character player)
        {
            while (true)
            {
                Console.WriteLine("\n인벤토리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");
                Console.WriteLine("[아이템 목록]");
                if (player.Inventory.Count > 0)
                {
                    foreach (var item in player.Inventory)
                    {
                        string equipped = player.Equipped.Contains(item) ? "[E]" : "";
                        Console.WriteLine($"- {equipped}{item.Name} | {item.Description}");
                    }
                }
                Console.WriteLine("\n1. 장착 관리");
                Console.WriteLine("0. 나가기\n");
                Console.Write("원하시는 행동을 입력해주세요.\n>> ");
                string input = Console.ReadLine();
                if (input == "1")
                    ManageEquip(player);
                else if (input == "0")
                    break;
                else
                    Console.WriteLine("잘못된 입력입니다\n");
            }
        }

        static void ManageEquip(Character player)
        {
            while (true)
            {
                Console.WriteLine("\n인벤토리 - 장착 관리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");
                Console.WriteLine("[아이템 목록]");
                for (int i = 0; i < player.Inventory.Count; i++)
                {
                    var item = player.Inventory[i];
                    bool isEq = player.Equipped.Contains(item);
                    Console.WriteLine($"{i + 1}. {(isEq ? "[E]" : "")}{item.Name} | {item.Description}");
                }
                Console.WriteLine("\n0. 나가기\n");
                Console.Write("원하시는 행동을 입력해주세요.\n>> ");
                string input = Console.ReadLine();
                if (input == "0") break;
                if (int.TryParse(input, out int idx) && idx >= 1 && idx <= player.Inventory.Count)
                {
                    var sel = player.Inventory[idx - 1];
                    if (player.Equipped.Contains(sel))
                    {
                        player.Equipped.Remove(sel);
                        Console.WriteLine($"{sel.Name} 장착을 해제했습니다.\n");
                    }
                    else
                    {
                        player.Equipped.Add(sel);
                        Console.WriteLine($"{sel.Name} 장착했습니다.\n");
                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다\n");
                }
            }
        }

        static void ShowShop(Character player, List<Item> shopItems)
        {
            while (true)
            {
                Console.WriteLine("\n상점");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.\n");
                Console.WriteLine("[보유 골드]");
                Console.WriteLine($"{player.Gold} G\n");
                Console.WriteLine("[아이템 목록]");
                foreach (var item in shopItems)
                {
                    bool owned = player.Inventory.Any(x => x.Name == item.Name);
                    string price = owned ? "구매완료" : $"{item.Price} G";
                    Console.WriteLine($"- {item.Name} | {item.Description} | {price}");
                }
                Console.WriteLine("\n1. 아이템 구매");
                Console.WriteLine("0. 나가기\n");
                Console.Write("원하시는 행동을 입력해주세요.\n>> ");
                string input = Console.ReadLine();
                if (input == "1")
                    PurchaseItem(player, shopItems);
                else if (input == "0")
                    break;
                else
                    Console.WriteLine("잘못된 입력입니다\n");
            }
        }

        static void PurchaseItem(Character player, List<Item> shopItems)
        {
            while (true)
            {
                Console.WriteLine("\n상점 - 아이템 구매");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.\n");
                Console.WriteLine("[보유 골드]");
                Console.WriteLine($"{player.Gold} G\n");
                Console.WriteLine("[아이템 목록]");
                for (int i = 0; i < shopItems.Count; i++)
                {
                    var item = shopItems[i];
                    bool owned = player.Inventory.Any(x => x.Name == item.Name);
                    string price = owned ? "구매완료" : $"{item.Price} G";
                    Console.WriteLine($"{i + 1}. {item.Name} | {item.Description} | {price}");
                }
                Console.WriteLine("\n0. 나가기\n");
                Console.Write("원하시는 행동을 입력해주세요.\n>> ");
                string input = Console.ReadLine();
                if (input == "0") break;
                if (int.TryParse(input, out int idx) && idx >= 1 && idx <= shopItems.Count)
                {
                    var item = shopItems[idx - 1];
                    bool owned = player.Inventory.Any(x => x.Name == item.Name);
                    if (owned)
                        Console.WriteLine("이미 구매한 아이템입니다.\n");
                    else if (player.Gold >= item.Price)
                    {
                        player.Gold -= item.Price;
                        player.Inventory.Add(item);
                        Console.WriteLine("구매를 완료했습니다.\n");
                    }
                    else
                        Console.WriteLine("Gold 가 부족합니다.\n");
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다\n");
                }
            }
        }

        static List<Item> InitializeShop()
        {
            return new List<Item>
            {
                new Item("수련자 갑옷", 0, 5, "수련에 도움을 주는 갑옷입니다.", 1000),
                new Item("무쇠갑옷", 0, 9, "무쇠로 만들어져 튼튼한 갑옷입니다.", 2000),
                new Item("스파르타의 갑옷", 0, 15, "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 3500),
                new Item("낡은 검", 2, 0, "쉽게 볼 수 있는 낡은 검 입니다.", 600),
                new Item("청동 도끼", 5, 0, "어디선가 사용됐던거 같은 도끼입니다.", 1500),
                new Item("스파르타의 창", 7, 0, "스파르타의 전사들이 사용했다는 전설의 창입니다.", 2500)
            };
        }
    }

    class Character
    {
        public string Name { get; }
        public string Job { get; }
        public int Level { get; set; }
        public int BaseAttack { get; }
        public int BaseDefense { get; }
        public int Health { get; set; }
        public int Gold { get; set; }
        public List<Item> Inventory { get; }
        public List<Item> Equipped { get; }

        public Character(string name, string job, int level, int baseAtk, int baseDef, int hp, int gold)
        {
            Name = name;
            Job = job;
            Level = level;
            BaseAttack = baseAtk;
            BaseDefense = baseDef;
            Health = hp;
            Gold = gold;
            Inventory = new List<Item>();
            Equipped = new List<Item>();
        }
    }

    class Item
    {
        public string Name { get; }
        public int AttackBonus { get; }
        public int DefenseBonus { get; }
        public string Description { get; }
        public int Price { get; }

        public Item(string name, int atk, int def, string desc, int price)
        {
            Name = name;
            AttackBonus = atk;
            DefenseBonus = def;
            Description = $"{(atk > 0 ? $"공격력 +{atk}" : $"방어력 +{def}")} | {desc}";
            Price = price;
        }
    }
}
