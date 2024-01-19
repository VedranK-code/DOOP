using System;
using System.Collections.Generic;

namespace DekoraterZadatak
{
    public interface IEffect{
        public void ApplyEffect();
    }

    public class NoEffect : IEffect{
        public void ApplyEffect(){
            Console.WriteLine("No Effect");
        }
    }
    public class BaseHealthEffect : IEffect
    {
        IEffect effect;
        public BaseHealthEffect(IEffect effect){
            this.effect=effect;
        }
        public void ApplyEffect()
        {
            Console.WriteLine("Apply Base Effect");
        }
    }
    public class HealthRegeneraton : BaseHealthEffect
    {
        public HealthRegeneraton(IEffect effect) : base(effect){
        }
        public void ApplyEffect()
        {
            base.ApplyEffect();
            Console.WriteLine("Health Regen");
        }
    }
    public class ArmorEffect : BaseHealthEffect
    {
        public ArmorEffect(IEffect effect) : base(effect){
        }
        public void ApplyEffect()
        {
            base.ApplyEffect();
            Console.WriteLine("Armor Increase");
        }
    }
    public class MagicDmg : BaseHealthEffect
    {
        public MagicDmg(IEffect effect) : base(effect){
        }
        public void ApplyEffect()
        {
            base.ApplyEffect();
            Console.WriteLine("Magic Dmg");
        }
    }
    public class Player
    {
        IEffect effect;
        
        public Player()
        {
            effect = new BaseHealthEffect(new HealthRegeneraton(new ArmorEffect(new MagicDmg(new NoEffect()))));
            effect.ApplyEffect();
        }
    }

    public static class ClientCode
    {
        static void Main()
        {
            new Player();
        }
    }
}