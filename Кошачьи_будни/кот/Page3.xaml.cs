using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Кошачьи_будни.кот
{
    public class Task
    {
        public string TaskName { get; set; }
        public string Status { get; set; }
        public int Estimation { get; set; }
    }
    public class Customer
    {
        public string CustomerName { get; set; }
       
        public Task[] Tasks { get; set; }
    }
    public partial class Page3 : Page
    {
        public ObservableCollection<Customer> Customers { get; set; }
        public Page3()
        {
            InitializeComponent();
            this.DataContext = this;
            Customers = new ObservableCollection<Customer>()
            {
                new Customer()
                {
                    CustomerName="Кормление котёнка",  
                    Tasks = new Task[]
                    {
                        new Task(){TaskName = "До 4 недель  ", Status = "Котята этого возраста питаются молоком \nматери. Если же по какой-то причине котенок \nостался без матери, его нужно кормить специальными \nзаменителями кошачьего молока через бутылочку \nкаждые 2–3 часа." },
                        new Task(){TaskName = "От 4 до 8 недель  ", Status = "В этот период начинают вводить прикорм. \nМожно использовать влажный корм для котят, \nразмоченный водой или заменителем молока. \nПостепенно увеличивают количество корма и \nуменьшают частоту кормления до 6 раз в день."  },
                        new Task(){TaskName = "От 8 до 12 недель  ", Status = "Котенка переводят на 4-разовое питание. \nВ рацион включают сухие и влажные корма для котят. \nВажно следить за тем, чтобы у него \nвсегда была свежая вода."},
                        new Task(){TaskName = "После 12 недель  ", Status = "Количество приемов пищи сокращается до 3 \nраз в сутки. В этом возрасте котята уже могут \nесть сухой корм, но важно выбирать \nспециализированные корма для котят, так как \nони содержат все необходимые витамины \nи минералы." },
                    }
                },
                new Customer()
                {
                    CustomerName="Мытьё котёнка ",
                    Tasks = new Task[]
                    {
                      new Task(){TaskName = "Подготовка", Status = "Подготовьте тёплую воду (около 37°C), \nмягкую губку или тряпочку, специальный \nшампунь для кошек и полотенце. Мытье \nлучше всего проводить в ванной \nкомнате или на кухне, где нет \nсквозняков." },
                      new Task(){TaskName = "Процесс мытья  ", Status = "Намочите котёнка водой, избегая \nпопадания воды в уши и глаза. Нанесите \nнебольшое количество шампуня и аккуратно \nпомассируйте шерсть. Смойте шампунь \nтеплой водой и тщательно высушите \nкотёнка полотенцем." },
                      new Task(){TaskName = "Частота  ", Status = "Мыть котёнка стоит только при \nнеобходимости, например, если он сильно испачкался. \nЧастое купание может нарушить \nестественный защитный слой кожи и \nшерсти." },

                    }
                },
                new Customer()
                {
                    CustomerName="Визиты к ветеринару", 
                    Tasks = new Task[]
                    {
                      new Task(){TaskName = "Первые месяцы жизни  ", Status = "После того как котенку исполнится \n8 недель, необходимо посетить ветеринара для \nпервичной вакцинации и осмотра. \nЗатем повторные прививки проводятся \nсогласно графику, обычно через 3–4 недели после первой." },
                      new Task(){TaskName = "Взрослый возраст ", Status = " Взрослых кошек рекомендуется показывать \nветеринару ежегодно для общего осмотра, \nвакцинации и контроля состояния \nздоровья." },
                      new Task(){TaskName = "Старческий возраст   ", Status = "Кошки старше 7 лет считаются пожилыми, \nпоэтому им требуется более частый осмотр – \nпримерно два раза в год. Это поможет \nвовремя выявить возможные возрастные \nпроблемы со здоровьем." },
                      new Task(){TaskName = "При появлении симптомов болезни ", Status = "Если у вашего питомца появились \nкакие-либо симптомы недомогания \n(например, рвота, диарея, отсутствие \nаппетита, изменения в поведении), \nнемедленно обратитесь к \nветеринару." },

                    }
                }
                
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }
    }
}