using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using marshall;

namespace coffeeVmc
{
    class Program
    {
        /// <summary>
        /// [0]:com
        /// [1]:code
        /// [2]:q
        /// [3]:price
        /// [4]:tmo,ms
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int ret = 0;
            Console.WriteLine("started,{0}", ret );

            //! check args
            if (args.Length < 5)
            {
                ret = -1;
                Console.WriteLine("end,{0}", ret );
                return;
            }

            {
                //Class1 vmc = new Class1();

                //vmc.Main_init();
                //vmc.m_vend_machine.vend_machine_serial_init(args[0], 115200);

                ////! code quantity price
                //vmc.m_vend_machine.vend_product_code_quantity_price(Int32.Parse(args[1]),
                //                                                     Int32.Parse(args[2]),
                //                                                     Int32.Parse(args[3]));

                //vmc.Main_start();

                ////! wait for proc
                //ret = 0;
                //for (int i = 0; i < 1000; i++)
                //{
                //    Console.WriteLine("{0},{1}", i, vmc.m_vend_machine.get_vmc_vend_state());
                //    Thread.Sleep(100);
                //}

                //vmc.Main_stop();
            }

            {
                ret = 0;
                int tmo = Int32.Parse(args[4]);
                //for (int i = 0; i < 100; i++)
                while( tmo > 0 )
                {
                    Console.WriteLine("ing,{0}", ret );
                    Thread.Sleep(100);
                    tmo -= 100;
                }
            }

            Console.WriteLine("end,{0}", ret );
        }
    }
}
