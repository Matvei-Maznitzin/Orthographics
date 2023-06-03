﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orthographics
{
    internal static class Program
    {
        /// <summary>
        /// Необходимо создать развивающую игру по теме "Правила русского языка". 
        /// Игра должна быть многопользовательской.У каждого игрока имеется прогресс,
        /// которого он достигает в процессе прохождения уровней.Уровни имеют различную степень сложности.
        /// Программа запоминает уровень, на котором остановился игрок,
        /// чтобы была возможность продолжить при следующем запуске.
        /// При входе в игру, программа должна предлагать создать учётную запись.
        /// Сначала предлагается изучить теорию. Изучение можно пропустить и перейти сразу к тестированию.
        /// Варианты видов тестовых карточек:
        ///     1. Выбор нескольких правильных ответов
        ///     2. Выбор одного правильного ответа
        ///     3. Вставить пропущенные слова/буквы
        ///     4. Найти ошибки
        ///     5. Установить соответствие
        ///     6. Написание ответа
        /// 1. Выбрать правила Русского языка (распространённые, в которых часто допускаются ошибки)
        /// 2. Выбрать способ хранения информации(о тестах, о пользователях)
        /// 3. Как красиво выводить теорию? (web-страницы + картинки) 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
