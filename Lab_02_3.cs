using System;

namespace Lab_02_3
{
    class Program {
    
    class DocumentWorker {
        
        public void OpenDocument(){
            Console.WriteLine("Документ открыт");
        }
        
        public virtual void EditDocument(){
            Console.WriteLine("Редактирование документа доступно в версии Pro");
        }
        
        public virtual void SaveDocument(){
            Console.WriteLine("Сохранение документа доступно в версии Pro");
        }
        
    }
    
    class ProDocumentWorker : DocumentWorker {
        
        public override void EditDocument(){
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument(){
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
        }
        
    }
    
    class ExpertDocumentWorker : ProDocumentWorker {
        
        public override void SaveDocument(){
            Console.WriteLine("Документ сохранен в новом формате");
        }
        
    }
    
    static void Main() {
        
        const string proKey = "BMSTU";
        const string expKey = "IU8-34";
        Console.WriteLine("");
        Console.WriteLine("Введите ключ доступа");
        string key = Console.ReadLine();
        DocumentWorker user;
        if (key == expKey) user = new ExpertDocumentWorker();
        else if (key == proKey) user = new ProDocumentWorker();
        else user = new DocumentWorker();
        
        user.OpenDocument();
        user.EditDocument();
        user.SaveDocument();
        
    }
    }

}