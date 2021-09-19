### СОЗДАЕМ ТЕКСТОВЫЙ РЕДАКТОР НА VISUAL BASIC

---

Сегодня, мы создадим редактор текста, который будет сохранять

ваш текст в указанном располдожении.

И так начнем!)))

---

1.Создаем новый проект в visual studio.

![ФОТО](https://raw.githubusercontent.com/YMP-CO/YMP_COMPANY/gh-pages/images/%D0%A1%D0%BD%D0%B8%D0%BC%D0%BE%D0%BA%20%D1%8D%D0%BA%D1%80%D0%B0%D0%BD%D0%B0%202020-11-27%20215854.png)

2.Добавляем на форму **richtextbox**

![ФОТО](https://raw.githubusercontent.com/YMP-CO/YMP_COMPANY/gh-pages/images/%D0%A1%D0%BD%D0%B8%D0%BC%D0%BE%D0%BA%20%D1%8D%D0%BA%D1%80%D0%B0%D0%BD%D0%B0%202020-11-27%20220052.png)

3.Добавляем **button** на форму.

![ФОТО](https://raw.githubusercontent.com/YMP-CO/YMP_COMPANY/gh-pages/images/%D0%A1%D0%BD%D0%B8%D0%BC%D0%BE%D0%BA%20%D1%8D%D0%BA%D1%80%D0%B0%D0%BD%D0%B0%202020-11-27%20220132.png)

4.Изменяем в окне **"свойства"** параметр **"text"** на **значение** "сохранить"

![ФОТО](https://raw.githubusercontent.com/YMP-CO/YMP_COMPANY/gh-pages/images/%D0%A1%D0%BD%D0%B8%D0%BC%D0%BE%D0%BA%20%D1%8D%D0%BA%D1%80%D0%B0%D0%BD%D0%B0%202020-11-27%20220221.png)

5.Нажимает 2 раза на кнопку и мв попадаем в **код** кнопки.

6.Вставляем код: (Вместо "Юрий" вы должны вставить свое имя пользователя)

               RichTextBox1.SaveFile("C:/Users/Юрий/111.rtf")
               
7.Запускаем программу

---

Поздравляю!Вы создали текстовый редактор!(блокнот)
               
