

/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

namespace Lab_02_1
{
    class Program {
    
    class ClassRoom {
        
        Pupil[] _pupils;
        
        public Pupil[] Pupils {get => _pupils;}
        
        public ClassRoom(Pupil[] src){
            _pupils = new Pupil[4];
            for (int i = 0 ; i < src.Length ; i++){
                _pupils[i] = src[i];
            }
        }

    }
    
    class Pupil {
        
        protected string _name;
        
        public Pupil(string str)
        {
            _name = str;
        }
        public virtual void Study() { }
        public virtual void Read() { }
        public virtual void Write() { }
        public virtual void Relax() { }
        
    }
    
    class ExcellentPupil : Pupil {
        
        public ExcellentPupil(string str) : base(str) { }
        
        public override void Study()
        {
            Console.WriteLine($"[Study] {_name} плотно ботает");
        }
        public override void Read()
        {
            Console.WriteLine($"[Read]  {_name} читает Кормена");
        }
        public override void Write()
        {
            Console.WriteLine($"[Write] {_name} делает лабы Сибири (лабы по АЯ сданы неделю назад)");
        }
        public override void Relax()
        {
            Console.WriteLine($"[Relax] {_name} спит");
        }
        
    }
    
    class GoodPupil : Pupil {
        
        public GoodPupil(string str) : base(str) { }
        
        public override void Study()
        {
            Console.WriteLine($"[Study] {_name} решает матан под lo-fi");
        }
        public override void Read()
        {
            Console.WriteLine($"[Read]  {_name} читает статьи на хабре");
        }
        public override void Write()
        {
            Console.WriteLine($"[Write] {_name} делает лабы по АЯ");
        }
        public override void Relax()
        {
            Console.WriteLine($"[Relax] {_name} играет в доту");
        }
        
    }
    
    class BadPupil : Pupil {
        
        public BadPupil(string str) : base(str) { }
        
        public override void Study()
        {
            Console.WriteLine($"[Study] {_name} катает лабы");
        }
        public override void Read()
        {
            Console.WriteLine($"[Read]  {_name} читает срачи в комментах");
        }
        public override void Write()
        {
            Console.WriteLine($"[Write] {_name} меняет названия переменных в скатанном коде");
        }
        public override void Relax()
        {
            Console.WriteLine($"[Relax] {_name} пьёт пиво");
        }
        
    }
    
    static void Main() {
        
        
        ClassRoom testClass = new ClassRoom( new Pupil[4] {
            new ExcellentPupil("Петя"),
            new GoodPupil("Ваня"),
            new BadPupil("Серёжа"),
            new GoodPupil("Маша")
        }
            );    
        
        
        foreach (Pupil obj in testClass.Pupils){
            obj.Study();
            obj.Read();
            obj.Write();
            obj.Relax();
        }
        
    }
    }

}