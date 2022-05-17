using UnityEngine;




/*! \mainpage Навигация
 *
 * Данная документация предназначена для программистов.
 * <p>Навигация по проекту:
 * - \subpage Weapons "Классы, отвечающие за оружие"
 * - \subpage Bullets "Классы, отвещающие за снаряды"
 * - \subpage Units "Классы, отвечающие за юнитов в игре"
 * - \subpage UI "Классы, отвечающие за UI"
 * - \subpage Locale "Классы, отвечающие за локализацию"
 */ 

/*! \page Weapons Классы отвечающие за оружие
 * - \ref Weapon "Weapon - класс родитель для всех видов оружия"
 * - \ref Blaster "Blaster - оружие, среляющие отдельными пулями перед собой"
 *
 */

/*! \page Bullets Классы, отвещающие за снаряды
 *
 * - \ref Bullet "Bullet - стандартный вид пули"
 *
 */


/*! \page Units Классы, отвечающие за юнитов в игре
 * - \ref Unit "Unit - класс родитель для всех юнитов"
 * - \ref Player "Player - Класс игрока"
 * - \subpage Enemies "Классы врагов"
 * 
 */


/*! \page Enemies Классы врагов
 * 
 * - \ref Enemy "Enemy - класс родитель для всех врагов"
 * 
 */

/*! \page UI Классы, отвечающие за UI
 * - \ref BGScroll "BGScroll - класс отвечает за задний фон"
 * - \ref Menu "Menu - класс отвечает за главное меню"
 * - \ref Settings  "Settings - класс отвечает за настройки"
 */

/*! \page Locale Классы, отвечающие за локализацию 
 * - \ref LocalizationManager "LocalizationManager - управляет основной логикой локализации"
 * - \ref LocalizedText "LocalizedText - класс, который нужно прикреплять к объекту локализации"
 * - \ref Localize  "Localize - класс объединяет все поля для локализации"
 */
///Родительский класс для все видов оружия

/*!
     

    Абстрактный класс Weapon содержит в себе общие поля и методы, которые должны иметься у каждого вида оружия.
   <p> Наследники данного класса должны реализовать абстрактный метод Shoot().
*/
public abstract class Weapon : MonoBehaviour
{
    
    [SerializeField] protected Bullet bullet;///< Используется в качестве снарядов для оружия.
    [SerializeField] protected string label;///< Название оружия.
    [SerializeField] protected int fireSpeed;///< Скорострельность нашего оружия.
    [SerializeField] protected Sprite sprite; ///< Изображение оружия в игре.
    
    
    /*!
     Абстрактный метод описывающий интерфейс для стрельбы из оружия. Принимает на вход один параметр.
     \param firePoint Место откуда будет производится выстрел
     \return Данный метод ничего не возвращает
    */
    public abstract void Shoot(Transform firePoint);

    


}
