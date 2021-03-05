using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s4_oop_2
{
    // На заметку: я думаю, реализовать удаление адресов все-таки можно
    // но адреса не будут полностью пропадать из файла настроек, а будут просто пропадать из отображаемого списка

    /// <summary>
    /// Класс, который хранит состояние приложения: все адреса, которые когда-либо были созданы
    /// Адреса нельзя удалять. Это костыль. Если удалять адреса, есть вероятность того, что будут существовать
    /// квартиры, связанные с несуществующими адресами
    /// </summary>
    class AdressPool : SortableBindingList<Adress>
    {
        static AdressPool instance = new AdressPool();
        // файл настроек
        static string path = @"settings\settings.json";
        static AdressPool() 
        {
            DeserializePool();

            // Всегда должен существовать хотя бы один адрес, чтобы квартирам было с чем связываться. Да, это тоже костыль
            if (instance.Count == 0)
            {
                instance.Add(Adress.CreateAdress());
            }
        }
        ~AdressPool()
        {
            SerializePool();
        }
        public static AdressPool GetPool()
        {
            return instance;
        }

        // Отдает адрес с заданным индексом. Отдает первый адрес в списке, который существует всегда, если индекс не введен
        public static Adress GetAdress(int index = 0)
        {
            foreach(var adress in instance)
            {
                if (adress.Id == index)
                {
                    return adress;
                }
            }
            return null;
        }

        private static void SerializePool()
        {
            
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine(JsonConvert.SerializeObject(instance, Newtonsoft.Json.Formatting.Indented));
            }
        }

        private static void DeserializePool()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                foreach (var flat in JsonConvert.DeserializeObject<AdressPool>(sr.ReadToEnd()))
                {
                    instance.Add(flat);
                }
            }
        }
    }
}
