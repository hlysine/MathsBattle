using MathsBattle.GameObjects.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsBattle.GameObjects
{
    public class Player
    {
        private int acCount = 0;
        public int ActiveCardCount
        {
            get
            {
                return acCount;
            }
            set
            {
                if (acCount != value) ActiveCard.Clear();
                acCount = value;
                FillActiveCard();
            }
        }
        private int mHP;
        private int mMP;

        public delegate void OnDeadEventHandler(Player sender);
        public event OnDeadEventHandler OnDead;

        public delegate void OnValueChangeEventHandler(Player sender);
        public event OnValueChangeEventHandler OnValueChange;

        public delegate void OnEffectsChangeEventHandler(Player sender);
        public event OnEffectsChangeEventHandler OnEffectsChange;

        public List<Cards.Card> CardSet { get; set; }
        public List<Cards.Card> ActiveCard { get; set; }
        public int HP
        {
            get
            {
                return mHP;
            }
            set
            {
                if (value <= MaxHP)
                {
                    mHP = value;
                }
                else
                {
                    mHP = MaxHP;
                }
                if (HP <= 0)
                {
                    OnDead?.Invoke(this);
                }
                OnValueChange?.Invoke(this);
            }
        }
        public int MP
        {
            get
            {
                return mMP;
            }
            set
            {
                if (value <= MaxMP)
                {
                    mMP = value;
                }
                else
                {
                    mMP = MaxMP;
                }
                OnValueChange?.Invoke(this);
            }
        }
        public int MaxHP;
        public int MaxMP;
        private List<TimedEvent> effects;
        public List<TimedEvent> Effects
        {
            get
            {
                return effects;
            }

            set
            {
                OnEffectsChange?.Invoke(this);
                effects = value;
            }
        }
        public string Name;

        private Random rnd;

        public Player(int CardCount, int _HP, int _MP, int maxHP, int maxMP, string _Name, List<Cards.Card> _CardSet)
        {
            rnd = new Random();
            MaxHP = maxHP;
            MaxMP = maxMP;
            HP = _HP;
            MP = _MP;
            Name = _Name;
            CardSet = _CardSet;
            Effects = new List<TimedEvent>();
            ActiveCard = new List<Card>();
            ActiveCardCount = CardCount;
        }

        public void Reset(int CardCount, int _HP, int _MP, int maxHP, int maxMP, string _Name, List<Cards.Card> _CardSet)
        {
            rnd = new Random();
            MaxHP = maxHP;
            MaxMP = maxMP;
            HP = _HP;
            MP = _MP;
            Name = _Name;
            CardSet = _CardSet;
            Effects = new List<TimedEvent>();
            ActiveCard = new List<Card>();
            ActiveCardCount = CardCount;
        }

        public void FillActiveCard()
        {
            if (CardSet == null) return;
            if (ActiveCard.Count < ActiveCardCount)
            {
                for (int i = 1; i <= (ActiveCardCount - ActiveCard.Count + 1); i++)
                {
                    bool updated = false;
                    while (!updated)
                    {
                        int idx = rnd.Next(CardSet.Count);
                        bool repeat = false;
                        for (int j = 0; j < ActiveCard.Count; j++)
                        {
                            if (CardSet[idx] == ActiveCard[j])
                            {
                                repeat = true;
                            }
                        }
                        if (!repeat)
                        {
                            ActiveCard.Add(CardSet[idx]);
                            updated = true;
                        }
                    }
                }
            }
        }
    }
}
