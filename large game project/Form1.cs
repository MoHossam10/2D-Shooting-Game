using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace large_game_project
{
    class ActorS
    {
        public int X, Y, W, H;
        public Rectangle rcDst;
        public Rectangle rcSrc;
        public Bitmap img;
        public Color loon;
        public int dx = 0;
        public int dy = 0;
        public int SpeedR = 0;
        public int SpeedL = 0;
        public int f = 0;

    }
    public partial class Form1 : Form
    {
        Timer t = new Timer();
        Bitmap off;
        List<ActorS> Lminu = new List<ActorS>();
        ActorS minu = new ActorS();
        List<ActorS> Lgameover = new List<ActorS>();
        ActorS gameover = new ActorS();
        List<ActorS> Lsafe = new List<ActorS>();
        ActorS safe = new ActorS();
        List<ActorS> Lbackground = new List<ActorS>();
        ActorS background = new ActorS();
        List<ActorS> Lground = new List<ActorS>();
        ActorS ground = new ActorS();
        List<ActorS> Lladder = new List<ActorS>();
        ActorS ladder = new ActorS();
        List<ActorS> Lelevator = new List<ActorS>();
        ActorS elevator = new ActorS();
        List<ActorS> Lamod = new List<ActorS>();
        ActorS amod = new ActorS();
        List<ActorS> Lflag = new List<ActorS>();
        ActorS flag = new ActorS();
        List<ActorS> Lhero = new List<ActorS>();
        ActorS hero = new ActorS();
        List<ActorS> LrosasHero = new List<ActorS>();
        ActorS rosasHero = new ActorS();
        List<ActorS> LlezarHero = new List<ActorS>();
        ActorS lezarHero = new ActorS();
        List<ActorS> LlezarLogo = new List<ActorS>();
        ActorS lezarLogo = new ActorS();
        List<ActorS> LheartLogo = new List<ActorS>();
        ActorS heartLogo = new ActorS();
        List<ActorS> Lenemy1 = new List<ActorS>();
        ActorS enemy1 = new ActorS();
        List<ActorS> Lenemy2 = new List<ActorS>();
        ActorS enemy2 = new ActorS();
        List<ActorS> Lenemy3 = new List<ActorS>();
        ActorS enemy3 = new ActorS();
        List<ActorS> Lrosas1 = new List<ActorS>();
        ActorS rosas1 = new ActorS();
        List<ActorS> Lrosas2 = new List<ActorS>();
        ActorS rosas2 = new ActorS();
        List<ActorS> Lrosas3 = new List<ActorS>();
        ActorS rosas3 = new ActorS();
        int CountTicks1 = 0;
        int CountTicks2 = 0;
        int CountTicks3 = 0;
        int CountTicks4 = 0;
        int flagKber = 0;
        int XScroll = 0;
        int YScroll = 0;
        int ct1 = 0;
        int ct2 = 0;
        int ct3 = 0;
        int ct4 = 0;
        int ct6 = 0;
        int flag1 = 0;
        int flag2 = 0;
        int flag3 = 0;
        int ct5 = 0;
        int flagjump = 0;
        int flagrosas = 0;
        int flaglezar = 0;
       
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Paint += Form1_Paint;
            this.Load += new EventHandler(Form1_Load);
            t.Tick += T_Tick;
            //t.Interval = 50;
            t.Start();
            MouseDown += Form1_MouseDown;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
           
        }

        

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                flagjump = 0;
                for (int i = 0; i < Lhero.Count; i++)
                {
                    hero.img = new Bitmap("4.bmp");
                    hero.img.MakeTransparent(hero.img.GetPixel(hero.img.Width - 1, 0));
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                for (int i = 0; i < Lhero.Count; i++)
                {
                    hero.img = new Bitmap("4.bmp");
                    hero.img.MakeTransparent(hero.img.GetPixel(hero.img.Width - 1, 0));
                }
            }
            
            if (e.KeyCode == Keys.Enter)
            {
                flaglezar = 0;
                if (flaglezar == 0)
                {
                   LlezarHero = new List<ActorS>();
                }
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (flagKber == 1)
            {

                if (e.KeyCode == Keys.Space)
                {
                    flagrosas = 1;
                }

                if (e.KeyCode == Keys.Enter)
                {
                    flaglezar = 1;
                    ct3++;
                }
                if (ct3 == 1)
                {
                    lezarLogo.img = new Bitmap("laser4.bmp");
                    lezarLogo.img.MakeTransparent(lezarLogo.img.GetPixel(lezarLogo.img.Width - 1, 0));
                }
                if (ct3 == 2)
                {
                    lezarLogo.img = new Bitmap("laser3.bmp");
                    lezarLogo.img.MakeTransparent(lezarLogo.img.GetPixel(lezarLogo.img.Width - 1, 0));
                }
                if (ct3 == 3)
                {
                    lezarLogo.img = new Bitmap("laser2.bmp");
                    lezarLogo.img.MakeTransparent(lezarLogo.img.GetPixel(lezarLogo.img.Width - 1, 0));
                }
                if (ct3 == 4)
                {
                    lezarLogo.img = new Bitmap("laser1.bmp");
                    lezarLogo.img.MakeTransparent(lezarLogo.img.GetPixel(lezarLogo.img.Width - 1, 0));
                }
                if (ct3 >= 5)
                {
                    lezarLogo.img = new Bitmap("laser0.bmp");
                    lezarLogo.img.MakeTransparent(lezarLogo.img.GetPixel(lezarLogo.img.Width - 1, 0));
                }


                if (e.KeyCode == Keys.Right)
                {
                    if (hero.X < ladder.X + ladder.W && hero.Y == 600 || hero.X < elevator.X + elevator.W && hero.Y == 370 || hero.X + hero.W < Lflag[0].X && hero.Y >= Lground[1].Y - 130)
                    {
                        ct1++;

                        if (XScroll < 7760)
                        {
                            XScroll += 10;


                        }




                        for (int i = 0; i < Lground.Count; i++)
                        {
                            Lground[i].X -= Lground[i].dx;
                        }

                        for (int i = 0; i < Lladder.Count; i++)
                        {
                            Lladder[i].X -= Lladder[i].dx;
                        }

                        for (int i = 0; i < Lelevator.Count; i++)
                        {
                            Lelevator[i].X -= Lelevator[i].dx;
                        }

                        for (int i = 0; i < Lamod.Count; i++)
                        {
                            Lamod[i].X -= Lamod[i].dx;
                        }

                        for (int i = 0; i < Lflag.Count; i++)
                        {
                            Lflag[i].X -= Lflag[i].dx;
                        }

                        for (int i = 0; i < Lenemy1.Count; i++)
                        {
                            Lenemy1[i].X -= Lenemy1[i].dx;
                        }

                        for (int i = 0; i < Lenemy2.Count; i++)
                        {
                            Lenemy2[i].X -= Lenemy2[i].dx;
                        }

                        for (int i = 0; i < Lenemy3.Count; i++)
                        {
                            Lenemy3[i].X -= Lenemy3[i].dx;
                        }

                        for (int i = 0; i < Lrosas1.Count; i++)
                        {
                            Lrosas1[i].X -= Lrosas1[i].dx;
                            Lrosas1[i].Y -= Lrosas1[i].dy;
                        }

                        for (int i = 0; i < Lrosas2.Count; i++)
                        {
                            Lrosas2[i].X -= Lrosas2[i].dx;
                            Lrosas2[i].Y -= Lrosas2[i].dy;
                        }

                        for (int i = 0; i < Lrosas3.Count; i++)
                        {
                            Lrosas3[i].X -= Lrosas3[i].dx;
                            Lrosas3[i].Y -= Lrosas3[i].dy;
                        }

                        for (int i = 0; i < Lhero.Count; i++)
                        {

                            Lhero[i].X += Lhero[i].dx;

                            if (ct1 == 1)
                            {
                                Lhero[i].img = new Bitmap("5.bmp");
                                Lhero[i].W = 65;
                                Lhero[i].H = 150;
                                Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                            }

                            if (ct1 == 2)
                            {
                                Lhero[i].img = new Bitmap("6.bmp");
                                Lhero[i].W = 65;
                                Lhero[i].H = 150;
                                Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                            }

                            if (ct1 == 3)
                            {
                                Lhero[i].img = new Bitmap("7.bmp");
                                Lhero[i].W = 65;
                                Lhero[i].H = 150;
                                Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                            }

                            if (ct1 == 4)
                            {
                                Lhero[i].img = new Bitmap("8.bmp");
                                Lhero[i].W = 65;
                                Lhero[i].H = 150;
                                Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                            }

                            if (ct1 == 5)
                            {
                                Lhero[i].img = new Bitmap("9.bmp");
                                Lhero[i].W = 65;
                                Lhero[i].H = 150;
                                Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                            }

                            if (ct1 == 6)
                            {
                                ct1 = 0;
                            }

                        }
                    }
                }
                if (e.KeyCode == Keys.Left)
                {
                    if (hero.Y == 600 || hero.X > ladder.X + ladder.W && hero.Y == 370 || hero.X > elevator.X + elevator.W && hero.Y >= Lground[1].Y - 130)
                    {
                        ct2++;
                        if (XScroll - 5 >= 0)
                        {
                            XScroll -= 10;

                        }

                        for (int i = 0; i < Lground.Count; i++)
                        {
                            Lground[i].X += Lground[i].dx;
                        }

                        for (int i = 0; i < Lladder.Count; i++)
                        {
                            Lladder[i].X += Lladder[i].dx;
                        }

                        for (int i = 0; i < Lelevator.Count; i++)
                        {
                            Lelevator[i].X += Lelevator[i].dx;
                        }

                        for (int i = 0; i < Lamod.Count; i++)
                        {
                            Lamod[i].X += Lamod[i].dx;
                        }

                        for (int i = 0; i < Lflag.Count; i++)
                        {
                            Lflag[i].X += Lflag[i].dx;
                        }

                        for (int i = 0; i < Lenemy1.Count; i++)
                        {
                            Lenemy1[i].X += Lenemy1[i].dx;
                        }

                        for (int i = 0; i < Lenemy2.Count; i++)
                        {
                            Lenemy2[i].X += Lenemy2[i].dx;
                        }

                        for (int i = 0; i < Lenemy3.Count; i++)
                        {
                            Lenemy3[i].X += Lenemy3[i].dx;
                        }

                        for (int i = 0; i < Lhero.Count; i++)
                        {
                            Lhero[i].X -= Lhero[i].dx;

                            if (ct2 == 1)
                            {
                                Lhero[i].img = new Bitmap("44.bmp");
                                Lhero[i].W = 65;
                                Lhero[i].H = 150;
                                Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                            }

                            if (ct2 == 2)
                            {
                                Lhero[i].img = new Bitmap("55.bmp");
                                Lhero[i].W = 65;
                                Lhero[i].H = 150;
                                Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                            }

                            if (ct2 == 3)
                            {
                                Lhero[i].img = new Bitmap("66.bmp");
                                Lhero[i].W = 65;
                                Lhero[i].H = 150;
                                Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                            }

                            if (ct2 == 4)
                            {
                                Lhero[i].img = new Bitmap("77.bmp");
                                Lhero[i].W = 65;
                                Lhero[i].H = 150;
                                Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                            }

                            if (ct2 == 5)
                            {
                                Lhero[i].img = new Bitmap("88.bmp");
                                Lhero[i].W = 65;
                                Lhero[i].H = 150;
                                Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                            }

                            if (ct2 == 6)
                            {
                                Lhero[i].img = new Bitmap("99.bmp");
                                Lhero[i].W = 65;
                                Lhero[i].H = 150;
                                Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                            }

                            if (ct2 == 7)
                            {
                                ct2 = 0;
                            }
                        }
                    }

                }

                if (e.KeyCode == Keys.Up)
                {
                    flagjump = 1;
                    /*
                    ct3++;

                    for (int i = 0; i < Lhero.Count; i++)
                    {
                        Lhero[i].X += Lhero[i].dx;

                        if (ct3 == 1)
                        {
                            Lhero[i].img = new Bitmap("111.bmp");
                            Lhero[i].W = 65;
                            Lhero[i].H = 150;
                            Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                        }

                        if (ct3 == 2)
                        {
                            Lhero[i].img = new Bitmap("222.bmp");
                            Lhero[i].W = 65;
                            Lhero[i].H = 150;
                            Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                        }

                        if (ct3 == 3)
                        {
                            Lhero[i].img = new Bitmap("333.bmp");
                            Lhero[i].W = 65;
                            Lhero[i].H = 150;
                            Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                        }

                        if (ct3 == 4)
                        {
                            Lhero[i].img = new Bitmap("444.bmp");
                            Lhero[i].W = 65;
                            Lhero[i].H = 150;
                            Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                        }

                        if (ct3 == 5)
                        {
                            Lhero[i].img = new Bitmap("555.bmp");
                            Lhero[i].W = 65;
                            Lhero[i].H = 150;
                            Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                        }

                        if (ct3 == 6)
                        {
                            Lhero[i].img = new Bitmap("666.bmp");
                            Lhero[i].W = 65;
                            Lhero[i].H = 150;
                            Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                        }

                        if (ct3 == 7)
                        {
                            Lhero[i].img = new Bitmap("777.bmp");
                            Lhero[i].W = 65;
                            Lhero[i].H = 150;
                            Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                        }

                        if (ct3 == 8)
                        {
                            Lhero[i].img = new Bitmap("888.bmp");
                            Lhero[i].W = 65;
                            Lhero[i].H = 150;
                            Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                        }

                        if (ct3 == 9)
                        {
                            ct3 = 0;
                        }
                    }
                    */
                }


                if (e.KeyCode == Keys.Down)
                {

                    ct4++;

                    for (int i = 0; i < Lhero.Count; i++)
                    {
                        Lhero[i].X += Lhero[i].dx;


                        if (ct4 == 1)
                        {
                            Lhero[i].img = new Bitmap("2222.bmp");


                            Lhero[i].W = 65;
                            Lhero[i].H = 150;
                            Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                        }

                        if (ct4 == 2)
                        {
                            ct4 = 0;
                        }
                    }
                }


                ModifyRects();
            }
            //DrawDubb(this.CreateGraphics());
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (flagKber == 0)
            {
                if (e.X >= 686 && e.X < 846 && e.Y >= 274 && e.Y < 315)
                {
                    Lminu = new List<ActorS>();
                    flagKber = 1;
                    if (flagKber == 1)
                    {
                        CreateBackGround();
                        Ground();
                        Ladder();
                        Elevator();
                        Amod();
                        Flag();
                        CreateHero();
                        CreateHeartLogo();
                        CreateLezarLogo();
                        
                    }
                }
            }


            if (flagKber == 2)
            {
                if (e.X >= 495 && e.X < 1091 && e.Y >= 464 && e.Y < 516)
                {
                    Lgameover = new List<ActorS>();
                    flagKber = 1;
                    if (flagKber == 1)
                    {
                        CreateBackGround();
                        Ground();
                        Ladder();
                        Elevator();
                        Amod();
                        Flag();
                        CreateHero();
                        CreateHeartLogo();
                        CreateLezarLogo();
                    }
                }
            }


        }

        void CreateMinu()
        {
            minu = new ActorS();
            minu.img = new Bitmap("1.bmp");
            minu.X = 0;
            minu.Y = 0;
            minu.W = 1600;
            minu.H = 793;
            Lminu.Add(minu);

            minu = new ActorS();
            minu.img = new Bitmap("2.bmp");
            minu.X = this.ClientSize.Width / 2 - 100;
            minu.Y = 200;
            minu.W = 200;
            minu.H = 200;
            minu.img.MakeTransparent(minu.img.GetPixel(minu.img.Width - 1, 0));
            Lminu.Add(minu);
        }
        void CreateGameOver()
        {
            gameover = new ActorS();
            gameover.img = new Bitmap("gameover.bmp");
            gameover.X = 0;
            gameover.Y = 0;
            gameover.W = 1600;
            gameover.H = 793;
            Lgameover.Add(gameover);
        }

        void CreateSafe()
        {
            safe = new ActorS();
            safe.img = new Bitmap("egyptissafe.bmp");
            safe.X = 500;
            safe.Y = 300;
            safe.W = 500;
            safe.H = 100;
            safe.img.MakeTransparent(safe.img.GetPixel(safe.img.Width - 1, 0));
            Lsafe.Add(safe);
        }

        void CreateBackGround()
        {

            background = new ActorS();
            background.img = new Bitmap("3.bmp");
            background.rcDst = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            background.rcSrc = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            //background.X = 0;
            //background.Y = 0;
            //background.W = 1540;
            //background.H = 795;
            Lbackground.Add(background);



        }

        void Ground()
        {

            ground = new ActorS();
            ground.img = new Bitmap("g1.bmp");
            /*
            ground.rcDst = new Rectangle(200, 500, this.ClientSize.Width, this.ClientSize.Height);
            ground.rcSrc = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            */
            ground.X = 2300;
            ground.Y = 500;
            ground.W = ground.img.Width;
            ground.H = 50;
            ground.dx = 5;
            ground.dy = 5;
            Lground.Add(ground);

            ground = new ActorS();
            ground.img = new Bitmap("g1.bmp");
            /*
            ground.rcDst = new Rectangle(200, 500, this.ClientSize.Width, this.ClientSize.Height);
            ground.rcSrc = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            */
            ground.X = Lground[0].X + Lground[0].W-100;
            ground.Y = 300;
            ground.W = ground.img.Width;
            ground.H = 50;
            ground.dx = 5;
            ground.dy = 5;
            Lground.Add(ground);
        }

        void Ladder()
        {
            ladder = new ActorS();
            ladder.img = new Bitmap("l.bmp");
            ladder.X = Lground[0].X;
            ladder.Y = 500;
            ladder.W = 80;
            ladder.H = 250;
            ladder.dx = 5;
            ladder.dy = 5;
            ladder.img.MakeTransparent(ladder.img.GetPixel(ladder.img.Width - 1, 0));
            Lladder.Add(ladder);
        }

        void Elevator()
        {
            elevator = new ActorS();
            elevator.img = new Bitmap("g1.bmp");
            elevator.X = Lground[1].X;
            elevator.Y = Lground[0].Y ;
            elevator.W = 100;
            elevator.H = 50;
            elevator.dx = 5;
            elevator.dy = 1;
            elevator.img.MakeTransparent(elevator.img.GetPixel(elevator.img.Width - 1, 0));
            Lelevator.Add(elevator);
        }

        void Amod()
        {
            amod = new ActorS();
            amod.img = new Bitmap("amod.bmp");
            amod.X = Lground[1].X + Lground[1].W - 100;
            amod.Y = Lground[1].Y - 190;
            amod.W = 80;
            amod.H = 200;
            amod.dx = 5;
            amod.dy = 5;
            amod.img.MakeTransparent(amod.img.GetPixel(amod.img.Width - 1, 0));
            Lamod.Add(amod);
        }

        void Flag()
        {
            flag = new ActorS();
            flag.img = new Bitmap("flag.bmp");
            flag.X = Lamod[0].X+80;
            flag.Y = Lamod[0].Y / 2+150;
            flag.W = 150;
            flag.H = 120;
            flag.dx = 5;
            flag.dy = 5;
            //flag.img.MakeTransparent(flag.img.GetPixel(flag.img.Width - 1, 0));
            Lflag.Add(flag);
        }

        void CreateHero()
        {
            hero = new ActorS();
            hero.img = new Bitmap("4.bmp");
            hero.X = 200;
            hero.Y = 600;
            hero.W = 65;
            hero.H = 150;
            hero.dx = 1;
            hero.dy = 5;
            hero.img.MakeTransparent(hero.img.GetPixel(hero.img.Width - 1, 0));
            Lhero.Add(hero);
        }

        void CreateRosasHero()
        {
            rosasHero = new ActorS();
            rosasHero.img = new Bitmap("r3.bmp");
            rosasHero.X = Lhero[0].X+50;
            rosasHero.Y = Lhero[0].Y + 50;
            rosasHero.W = 50;
            rosasHero.H = 10;
            rosasHero.dx = 15;
            rosasHero.dy = 1;
            rosasHero.img.MakeTransparent(rosasHero.img.GetPixel(rosasHero.img.Width - 1, 0));
            LrosasHero.Add(rosasHero);
        }

        void CreateLezarHero()
        {
            lezarHero = new ActorS();
            lezarHero.img = new Bitmap("lezar.bmp");
            lezarHero.X = Lhero[0].X + 50;
            lezarHero.Y = Lhero[0].Y + 30;
            lezarHero.W = 1300;
            lezarHero.H = 50;
            lezarHero.dx = 15;
            lezarHero.dy = 1;
            lezarHero.img.MakeTransparent(lezarHero.img.GetPixel(lezarHero.img.Width - 1, 0));
            LlezarHero.Add(lezarHero);
        }

        void CreateHeartLogo()
        {
            heartLogo = new ActorS();
            heartLogo.img = new Bitmap("heart5.bmp");
            heartLogo.X = -70;
            heartLogo.Y = -50;
            heartLogo.W = 250;
            heartLogo.H = 150;
            heartLogo.dx = 15;
            heartLogo.dy = 1;
            heartLogo.img.MakeTransparent(heartLogo.img.GetPixel(heartLogo.img.Width - 1, 0));
            LheartLogo.Add(heartLogo);
        }

        void CreateLezarLogo()
        {
            lezarLogo = new ActorS();
            lezarLogo.img = new Bitmap("laser5.bmp");
            lezarLogo.X = heartLogo.X+ heartLogo.W - 70;
            lezarLogo.Y = 15;
            lezarLogo.W = 100;
            lezarLogo.H = 50;
            lezarLogo.dx = 15;
            lezarLogo.dy = 1;
            lezarLogo.img.MakeTransparent(lezarLogo.img.GetPixel(lezarLogo.img.Width - 1, 0));
            LlezarLogo.Add(lezarLogo);
        }

        void CreateEnemy1()
        {
            enemy1 = new ActorS();
            enemy1.img = new Bitmap("e1.bmp");
            /*
            enemy1.rcDst = new Rectangle(500, 600, 100, 150);
            enemy1.rcSrc = new Rectangle(0, 0, enemy1.img.Width, enemy1.img.Height);
            */
            enemy1.X = 1200;
            enemy1.Y = 600;
            enemy1.W = 100;
            enemy1.H = 150;
            enemy1.dx = 5;
            enemy1.dy = 5;
            enemy1.img.MakeTransparent(enemy1.img.GetPixel(enemy1.img.Width - 1, 0));
            Lenemy1.Add(enemy1);

            enemy1 = new ActorS();
            enemy1.img = new Bitmap("e1.bmp");
            /*
            enemy1.rcDst = new Rectangle(500, 600, 100, 150);
            enemy1.rcSrc = new Rectangle(0, 0, enemy1.img.Width, enemy1.img.Height);
            */
            enemy1.X = 1400;
            enemy1.Y = 600;
            enemy1.W = 100;
            enemy1.H = 150;
            enemy1.dx = 5;
            enemy1.dy = 5;
            enemy1.img.MakeTransparent(enemy1.img.GetPixel(enemy1.img.Width - 1, 0));
            Lenemy1.Add(enemy1);

            enemy1 = new ActorS();
            enemy1.img = new Bitmap("e1.bmp");
            /*
            enemy1.rcDst = new Rectangle(500, 600, 100, 150);
            enemy1.rcSrc = new Rectangle(0, 0, enemy1.img.Width, enemy1.img.Height);
            */
            enemy1.X = 1600;
            enemy1.Y = 600;
            enemy1.W = 100;
            enemy1.H = 150;
            enemy1.dx = 5;
            enemy1.dy = 5;
            enemy1.img.MakeTransparent(enemy1.img.GetPixel(enemy1.img.Width - 1, 0));
            Lenemy1.Add(enemy1);
        }

        void CreateEnemy2()
        {
            enemy2 = new ActorS();
            enemy2.img = new Bitmap("e11.bmp");
            /*
            enemy2.rcDst = new Rectangle(700, 600, 100, 150);
            enemy2.rcSrc = new Rectangle(0, 0, enemy2.img.Width, enemy2.img.Height);
            */
            enemy2.X = Lground[0].X+Lground[0].W-400;
            enemy2.Y = Lground[0].Y-130;
            enemy2.W = 100;
            enemy2.H = 150;
            enemy2.dx = 5;
            enemy2.dy = 5;
            enemy2.img.MakeTransparent(enemy2.img.GetPixel(enemy2.img.Width - 1, 0));
            Lenemy2.Add(enemy2);

            enemy2 = new ActorS();
            enemy2.img = new Bitmap("e11.bmp");
            /*
            enemy2.rcDst = new Rectangle(700, 600, 100, 150);
            enemy2.rcSrc = new Rectangle(0, 0, enemy2.img.Width, enemy2.img.Height);
            */
            enemy2.X = Lground[0].X + Lground[0].W - 300;
            enemy2.Y = Lground[0].Y - 130;
            enemy2.W = 100;
            enemy2.H = 150;
            enemy2.dx = 5;
            enemy2.dy = 5;
            enemy2.img.MakeTransparent(enemy2.img.GetPixel(enemy2.img.Width - 1, 0));
            Lenemy2.Add(enemy2);

            enemy2 = new ActorS();
            enemy2.img = new Bitmap("e11.bmp");
            /*
            enemy2.rcDst = new Rectangle(700, 600, 100, 150);
            enemy2.rcSrc = new Rectangle(0, 0, enemy2.img.Width, enemy2.img.Height);
            */
            enemy2.X = Lground[0].X + Lground[0].W - 200;
            enemy2.Y = Lground[0].Y - 130;
            enemy2.W = 100;
            enemy2.H = 150;
            enemy2.dx = 5;
            enemy2.dy = 5;
            enemy2.img.MakeTransparent(enemy2.img.GetPixel(enemy2.img.Width - 1, 0));
            Lenemy2.Add(enemy2);
        }
        void CreateEnemy3()
        {
            enemy3 = new ActorS();
            enemy3.img = new Bitmap("e111.bmp");
            /*
            enemy3.rcDst = new Rectangle(900, 600, 100, 150);
            enemy3.rcSrc = new Rectangle(0, 0, enemy3.img.Width, enemy3.img.Height);
            */
            enemy3.X = Lground[1].X + Lground[1].W - 400;
            enemy3.Y = Lground[1].Y - 130;
            enemy3.W = 100;
            enemy3.H = 150;
            enemy3.dx = 5;
            enemy3.dy = 5;
            enemy3.img.MakeTransparent(enemy3.img.GetPixel(enemy3.img.Width - 1, 0));
            Lenemy3.Add(enemy3);

            enemy3 = new ActorS();
            enemy3.img = new Bitmap("e111.bmp");
            /*
            enemy3.rcDst = new Rectangle(900, 600, 100, 150);
            enemy3.rcSrc = new Rectangle(0, 0, enemy3.img.Width, enemy3.img.Height);
            */
            enemy3.X = Lground[1].X + Lground[1].W - 300;
            enemy3.Y = Lground[1].Y - 130;
            enemy3.W = 100;
            enemy3.H = 150;
            enemy3.dx = 5;
            enemy3.dy = 5;
            enemy3.img.MakeTransparent(enemy3.img.GetPixel(enemy3.img.Width - 1, 0));
            Lenemy3.Add(enemy3);

            enemy3 = new ActorS();
            enemy3.img = new Bitmap("e111.bmp");
            /*
            enemy3.rcDst = new Rectangle(900, 600, 100, 150);
            enemy3.rcSrc = new Rectangle(0, 0, enemy3.img.Width, enemy3.img.Height);
            */
            enemy3.X = Lground[1].X + Lground[1].W - 200;
            enemy3.Y = Lground[1].Y - 130;
            enemy3.W = 100;
            enemy3.H = 150;
            enemy3.dx = 5;
            enemy3.dy = 5;
            enemy3.img.MakeTransparent(enemy3.img.GetPixel(enemy3.img.Width - 1, 0));
            Lenemy3.Add(enemy3);
        }

        void CreateRosas1()
        {
            rosas1 = new ActorS();
            rosas1.img = new Bitmap("r1.bmp");
            rosas1.X = Lenemy1[0].X;
            rosas1.Y = Lenemy1[0].Y + 50;
            rosas1.W = 50;
            rosas1.H = 10;
            rosas1.dx = 15;
            rosas1.dy = 1;
            rosas1.img.MakeTransparent(rosas1.img.GetPixel(rosas1.img.Width - 1, 0));
            Lrosas1.Add(rosas1);

            rosas1 = new ActorS();
            rosas1.img = new Bitmap("r1.bmp");
            rosas1.X = Lenemy1[1].X;
            rosas1.Y = Lenemy1[1].Y + 50;
            rosas1.W = 50;
            rosas1.H = 10;
            rosas1.dx = 15;
            rosas1.dy = 1;
            rosas1.img.MakeTransparent(rosas1.img.GetPixel(rosas1.img.Width - 1, 0));
            Lrosas1.Add(rosas1);

            rosas1 = new ActorS();
            rosas1.img = new Bitmap("r1.bmp");
            rosas1.X = Lenemy1[2].X;
            rosas1.Y = Lenemy1[2].Y + 50;
            rosas1.W = 50;
            rosas1.H = 10;
            rosas1.dx = 15;
            rosas1.dy = 1;
            rosas1.img.MakeTransparent(rosas1.img.GetPixel(rosas1.img.Width - 1, 0));
            Lrosas1.Add(rosas1);
        }

        void CreateRosas2()
        {
            rosas2 = new ActorS();
            rosas2.img = new Bitmap("r2.bmp");
            rosas2.X = Lenemy2[0].X;
            rosas2.Y = Lenemy2[0].Y + 60;
            rosas2.W = 50;
            rosas2.H = 10;
            rosas2.dx = 20;
            rosas2.dy = 1;
            rosas2.img.MakeTransparent(rosas2.img.GetPixel(rosas2.img.Width - 1, 0));
            Lrosas2.Add(rosas2);

            rosas2 = new ActorS();
            rosas2.img = new Bitmap("r2.bmp");
            rosas2.X = Lenemy2[1].X;
            rosas2.Y = Lenemy2[1].Y + 60;
            rosas2.W = 50;
            rosas2.H = 10;
            rosas2.dx = 20;
            rosas2.dy = 1;
            rosas2.img.MakeTransparent(rosas2.img.GetPixel(rosas2.img.Width - 1, 0));
            Lrosas2.Add(rosas2);

            rosas2 = new ActorS();
            rosas2.img = new Bitmap("r2.bmp");
            rosas2.X = Lenemy2[2].X;
            rosas2.Y = Lenemy2[2].Y + 60;
            rosas2.W = 50;
            rosas2.H = 10;
            rosas2.dx = 20;
            rosas2.dy = 1;
            rosas2.img.MakeTransparent(rosas2.img.GetPixel(rosas2.img.Width - 1, 0));
            Lrosas2.Add(rosas2);
        }

        void CreateRosas3()
        {
            rosas3 = new ActorS();
            rosas3.img = new Bitmap("r1.bmp");
            rosas3.X = Lenemy3[0].X;
            rosas3.Y = Lenemy3[0].Y + 100;
            rosas3.W = 50;
            rosas3.H = 10;
            rosas3.dx = 20;
            rosas3.dy = 1;
            rosas3.img.MakeTransparent(rosas3.img.GetPixel(rosas3.img.Width - 1, 0));
            Lrosas3.Add(rosas3);

            rosas3 = new ActorS();
            rosas3.img = new Bitmap("r2.bmp");
            rosas3.X = Lenemy3[1].X;
            rosas3.Y = Lenemy3[1].Y + 100;
            rosas3.W = 50;
            rosas3.H = 10;
            rosas3.dx = 20;
            rosas3.dy = 1;
            rosas3.img.MakeTransparent(rosas3.img.GetPixel(rosas3.img.Width - 1, 0));
            Lrosas3.Add(rosas3);

            rosas3 = new ActorS();
            rosas3.img = new Bitmap("r1.bmp");
            rosas3.X = Lenemy3[2].X;
            rosas3.Y = Lenemy3[2].Y + 100;
            rosas3.W = 50;
            rosas3.H = 10;
            rosas3.dx = 20;
            rosas3.dy = 1;
            rosas3.img.MakeTransparent(rosas3.img.GetPixel(rosas3.img.Width - 1, 0));
            Lrosas3.Add(rosas3);
        }

        void ModifyRects()
        {
            for (int i = 0; i < Lbackground.Count; i++)
            {
                Lbackground[i].rcSrc = new Rectangle(XScroll, YScroll, this.ClientSize.Width, this.ClientSize.Height);
            }
            
        }


        private void T_Tick(object sender, EventArgs e)
        {
            if (flagKber == 2)
            {
                CreateGameOver();
            }

            if (flagKber == 3)
            {
                CreateSafe();
            }

            if (flagKber == 1)
            {

                //hero
                if (flagrosas == 1)
                {
                    for (int i = 0; i < Lhero.Count; i++)
                    {
                        //Lhero[i].X += Lhero[i].dx;

                        if (CountTicks4 % 1 == 0)
                        {
                            Lhero[i].img = new Bitmap("hero1.bmp");

                            Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));

                        }

                        if (CountTicks4 % 2 == 0)
                        {
                            Lhero[i].img = new Bitmap("hero2.bmp");

                            Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                        }

                        if (CountTicks4 % 1 == 0)
                        {
                            CreateRosasHero();


                        }

                        if (CountTicks4 % 3 == 0)
                        {
                            Lhero[i].img = new Bitmap("hero3.bmp");

                            Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                        }



                        flagrosas = 0;
                    }

                }

                if (flaglezar == 1)
                {
                    for (int i = 0; i < Lhero.Count; i++)
                    {
                        //Lhero[i].X += Lhero[i].dx;

                        if (CountTicks4 % 1 == 0)
                        {
                            Lhero[i].img = new Bitmap("hero1.bmp");

                            Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));

                        }

                        if (CountTicks4 % 2 == 0)
                        {
                            Lhero[i].img = new Bitmap("hero2.bmp");

                            Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                        }

                        if (CountTicks4 % 1 == 0)
                        {
                            if (ct3 <= 5)
                            {
                                CreateLezarHero();
                            }

                        }

                        if (CountTicks4 % 3 == 0)
                        {
                            Lhero[i].img = new Bitmap("hero3.bmp");

                            Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                        }



                        flaglezar = 0;
                    }
                }

                //tsadom
                for (int i = 0; i < Lrosas1.Count; i++)
                {
                    if (Lrosas1[i].X <= Lhero[0].X + Lhero[0].W && Lrosas1[i].X > Lhero[0].X && Lrosas1[i].Y >= Lhero[0].Y && Lrosas1[i].Y < Lhero[0].Y + Lhero[0].H)
                    {
                        ct6++;
                        Lrosas1[i].X = 10000000;
                        Lrosas1[i].dx = 0;
                        Lrosas1[i].dy = 0;
                    }
                }

                for (int i = 0; i < Lrosas2.Count; i++)
                {
                    if (Lrosas2[i].X <= Lhero[0].X + Lhero[0].W && Lrosas2[i].X > Lhero[0].X && Lrosas2[i].Y >= Lhero[0].Y && Lrosas2[i].Y < Lhero[0].Y + Lhero[0].H)
                    {
                        ct6++;
                        Lrosas2[i].X = 10000000;
                        Lrosas2[i].dx = 0;
                        Lrosas2[i].dy = 0;
                    }
                }

                for (int i = 0; i < Lrosas3.Count; i++)
                {
                    if (Lrosas3[i].X <= Lhero[0].X + Lhero[0].W && Lrosas3[i].X > Lhero[0].X && Lrosas3[i].Y >= Lhero[0].Y && Lrosas3[i].Y < Lhero[0].Y + Lhero[0].H)
                    {
                        ct6++;
                        Lrosas3[i].X = 10000000;
                        Lrosas3[i].dx = 0;
                        Lrosas3[i].dy = 0;
                    }
                }

                for (int i = 0; i < Lenemy1.Count; i++)
                {
                    if (Lhero[0].X + Lhero[0].W >= Lenemy1[i].X && Lhero[0].X + Lhero[0].W < Lenemy1[i].X + Lenemy1[i].W && Lhero[0].Y >= Lenemy1[i].Y && Lhero[0].Y < Lenemy1[i].Y + Lenemy1[i].H)
                    {
                        ct6 = 5;
                    }
                }

                for (int i = 0; i < Lenemy2.Count; i++)
                {
                    if (Lhero[0].X + Lhero[0].W >= Lenemy2[i].X && Lhero[0].X + Lhero[0].W < Lenemy2[i].X + Lenemy2[i].W && Lhero[0].Y >= Lenemy2[i].Y && Lhero[0].Y < Lenemy2[i].Y + Lenemy2[i].H)
                    {
                        ct6 = 5;
                    }
                }

                for (int i = 0; i < Lenemy3.Count; i++)
                {
                    if (Lhero[0].X + Lhero[0].W >= Lenemy3[i].X && Lhero[0].X + Lhero[0].W < Lenemy3[i].X + Lenemy3[i].W && Lhero[0].Y >= Lenemy3[i].Y && Lhero[0].Y < Lenemy3[i].Y + Lenemy3[i].H)
                    {
                        ct6 = 5;
                    }
                }



                for (int i = 0; i < LrosasHero.Count; i++)
                {
                    if (LrosasHero[i].X + LrosasHero[i].W >= Lenemy1[0].X && LrosasHero[i].X + LrosasHero[i].W < Lenemy1[0].X + Lenemy1[0].W && LrosasHero[i].Y >= Lenemy1[0].Y && LrosasHero[i].Y < Lenemy1[0].Y + Lenemy1[0].H)
                    {
                        Lenemy1[0].Y = 1000000000;
                        LrosasHero[i].Y = 1000000000;
                    }
                }

                for (int i = 0; i < LrosasHero.Count; i++)
                {
                    if (LrosasHero[i].X + LrosasHero[i].W >= Lenemy1[1].X && LrosasHero[i].X + LrosasHero[i].W < Lenemy1[1].X + Lenemy1[1].W && LrosasHero[i].Y >= Lenemy1[1].Y && LrosasHero[i].Y < Lenemy1[1].Y + Lenemy1[1].H)
                    {
                        Lenemy1[1].Y = 1000000000;
                        LrosasHero[i].Y = 1000000000;
                    }
                }

                for (int i = 0; i < LrosasHero.Count; i++)
                {
                    if (LrosasHero[i].X + LrosasHero[i].W >= Lenemy1[2].X && LrosasHero[i].X + LrosasHero[i].W < Lenemy1[2].X + Lenemy1[2].W && LrosasHero[i].Y >= Lenemy1[2].Y && LrosasHero[i].Y < Lenemy1[2].Y + Lenemy1[2].H)
                    {
                        Lenemy1[2].Y = 1000000000;
                        LrosasHero[i].Y = 1000000000;
                    }
                }



                for (int i = 0; i < LrosasHero.Count; i++)
                {
                    if (LrosasHero[i].X + LrosasHero[i].W >= Lenemy2[0].X && LrosasHero[i].X + LrosasHero[i].W < Lenemy2[0].X + Lenemy2[0].W && LrosasHero[i].Y >= Lenemy2[0].Y && LrosasHero[i].Y < Lenemy2[0].Y + Lenemy2[0].H)
                    {
                        Lenemy2[0].Y = 1000000000;
                        LrosasHero[i].Y = 1000000000;
                    }
                }

                for (int i = 0; i < LrosasHero.Count; i++)
                {
                    if (LrosasHero[i].X + LrosasHero[i].W >= Lenemy2[1].X && LrosasHero[i].X + LrosasHero[i].W < Lenemy2[1].X + Lenemy2[1].W && LrosasHero[i].Y >= Lenemy2[1].Y && LrosasHero[i].Y < Lenemy2[1].Y + Lenemy2[1].H)
                    {
                        Lenemy2[1].Y = 1000000000;
                        LrosasHero[i].Y = 1000000000;
                    }
                }

                for (int i = 0; i < LrosasHero.Count; i++)
                {
                    if (LrosasHero[i].X + LrosasHero[i].W >= Lenemy2[2].X && LrosasHero[i].X + LrosasHero[i].W < Lenemy2[2].X + Lenemy2[2].W && LrosasHero[i].Y >= Lenemy2[2].Y && LrosasHero[i].Y < Lenemy2[2].Y + Lenemy2[2].H)
                    {
                        Lenemy2[2].Y = 1000000000;
                        LrosasHero[i].Y = 1000000000;
                    }
                }



                for (int i = 0; i < LrosasHero.Count; i++)
                {
                    if (LrosasHero[i].X + LrosasHero[i].W >= Lenemy3[0].X && LrosasHero[i].X + LrosasHero[i].W < Lenemy3[0].X + Lenemy3[0].W && LrosasHero[i].Y >= Lenemy3[0].Y && LrosasHero[i].Y < Lenemy3[0].Y + Lenemy3[0].H)
                    {
                        Lenemy3[0].Y = 1000000000;
                        LrosasHero[i].Y = 1000000000;
                    }
                }

                for (int i = 0; i < LrosasHero.Count; i++)
                {
                    if (LrosasHero[i].X + LrosasHero[i].W >= Lenemy3[1].X && LrosasHero[i].X + LrosasHero[i].W < Lenemy3[1].X + Lenemy3[1].W && LrosasHero[i].Y >= Lenemy3[1].Y && LrosasHero[i].Y < Lenemy3[1].Y + Lenemy3[1].H)
                    {
                        Lenemy3[1].Y = 1000000000;
                        LrosasHero[i].Y = 1000000000;
                    }
                }

                for (int i = 0; i < LrosasHero.Count; i++)
                {
                    if (LrosasHero[i].X + LrosasHero[i].W >= Lenemy3[2].X && LrosasHero[i].X + LrosasHero[i].W < Lenemy3[2].X + Lenemy3[2].W && LrosasHero[i].Y >= Lenemy3[2].Y && LrosasHero[i].Y < Lenemy3[2].Y + Lenemy3[2].H)
                    {
                        Lenemy3[2].Y = 1000000000;
                        LrosasHero[i].Y = 1000000000;
                    }
                }





                for (int i = 0; i < Lenemy1.Count; i++)
                {
                    if (/*lezarHero.X + lezarHero.W >= Lenemy1[i].X && lezarHero.X + lezarHero.W < Lenemy1[i].X + Lenemy1[i].W &&*/ lezarHero.Y >= Lenemy1[i].Y && lezarHero.Y < Lenemy1[i].Y + Lenemy1[i].H)
                    {
                        Lenemy1[i].Y = 1000000000;
                    }
                }

                for (int i = 0; i < Lenemy2.Count; i++)
                {
                    if (/*lezarHero.X + lezarHero.W >= Lenemy2[i].X && lezarHero.X + lezarHero.W < Lenemy2[i].X + Lenemy2[i].W &&*/ lezarHero.Y >= Lenemy2[i].Y && lezarHero.Y < Lenemy2[i].Y + Lenemy2[i].H)
                    {
                        Lenemy2[i].Y = 1000000000;
                    }
                }

                for (int i = 0; i < Lenemy3.Count; i++)
                {
                    if (/*lezarHero.X + lezarHero.W >= Lenemy3[i].X && lezarHero.X + lezarHero.W < Lenemy3[i].X + Lenemy3[i].W && */lezarHero.Y >= Lenemy3[i].Y && lezarHero.Y < Lenemy3[i].Y + Lenemy3[i].H)
                    {
                        Lenemy3[i].Y = 1000000000;
                    }
                }




                if (ct6 == 1)
                {
                    heartLogo.img = new Bitmap("heart4.bmp");
                    heartLogo.img.MakeTransparent(heartLogo.img.GetPixel(heartLogo.img.Width - 1, 0));
                }
                if (ct6 == 2)
                {
                    heartLogo.img = new Bitmap("heart3.bmp");
                    heartLogo.img.MakeTransparent(heartLogo.img.GetPixel(heartLogo.img.Width - 1, 0));
                }
                if (ct6 == 3)
                {
                    heartLogo.img = new Bitmap("heart2.bmp");
                    heartLogo.img.MakeTransparent(heartLogo.img.GetPixel(heartLogo.img.Width - 1, 0));
                }
                if (ct6 == 4)
                {
                    heartLogo.img = new Bitmap("heart1.bmp");
                    heartLogo.img.MakeTransparent(heartLogo.img.GetPixel(heartLogo.img.Width - 1, 0));
                }
                if (ct6 >= 5)
                {

                    heartLogo.img = new Bitmap("heart0.bmp");
                    heartLogo.img.MakeTransparent(heartLogo.img.GetPixel(heartLogo.img.Width - 1, 0));



                    hero.img = new Bitmap("mot8.bmp");
                    hero.img.MakeTransparent(hero.img.GetPixel(hero.img.Width - 1, 0));


                    if (CountTicks4 % 10 == 0)
                    {
                        Lminu = new List<ActorS>();

                        Lbackground = new List<ActorS>();

                        Lground = new List<ActorS>();

                        Lladder = new List<ActorS>();

                        Lelevator = new List<ActorS>();

                        Lamod = new List<ActorS>();

                        Lflag = new List<ActorS>();

                        Lhero = new List<ActorS>();
                        hero.X = 200;
                        hero.Y = 600;

                        LrosasHero = new List<ActorS>();

                        LlezarHero = new List<ActorS>();

                        LlezarLogo = new List<ActorS>();

                        LheartLogo = new List<ActorS>();
                        /*
                        Lenemy1 = new List<ActorS>();

                        Lenemy2 = new List<ActorS>();

                        Lenemy3 = new List<ActorS>();

                        Lrosas1 = new List<ActorS>();

                        Lrosas2 = new List<ActorS>();

                        Lrosas3 = new List<ActorS>();
                        */
                        ct1 = 0;
                        ct2 = 0;
                        ct3 = 0;
                        ct4 = 0;
                        ct5 = 0;
                        ct6 = 0;
                        
                        
                        XScroll = 0;
                        YScroll = 0;
                        
                        

                        flagKber = 2;
                    }

                }






                //enemy1
                if (flag1 == 0)
                {
                    if (CountTicks1 % 50 == 0)
                    {
                        CreateEnemy1();
                        flag1 = 1;
                    }

                }
                if (CountTicks1 % 55 == 0)
                {
                    for (int i = 0; i < Lenemy1.Count; i++)
                    {
                        Lenemy1[i].img = new Bitmap("e2.bmp");
                        Lenemy1[i].img.MakeTransparent(Lenemy1[i].img.GetPixel(Lenemy1[i].img.Width - 1, 0));
                    }
                }
                if (CountTicks1 % 60 == 0)
                {

                    CreateRosas1();

                }
                if (CountTicks1 % 65 == 0)
                {
                    for (int i = 0; i < Lenemy1.Count; i++)
                    {
                        Lenemy1[i].img = new Bitmap("e3.bmp");
                        Lenemy1[i].img.MakeTransparent(Lenemy1[i].img.GetPixel(Lenemy1[i].img.Width - 1, 0));
                    }
                }
                if (CountTicks1 % 1 == 0)
                {
                    for (int i = 0; i < Lrosas1.Count; i++)
                    {
                        Lrosas1[i].X -= Lrosas1[i].dx;
                        Lrosas1[i].Y -= Lrosas1[i].dy;
                    }
                }

                //enemy2

                if (flag2 == 0)
                {
                    if (CountTicks2 % 150 == 0)
                    {
                        CreateEnemy2();
                        flag2 = 1;
                    }

                }
                if (hero.Y == 370)
                {
                    if (CountTicks2 % 100 == 0)
                    {

                        CreateRosas2();

                    }

                    if (CountTicks2 % 105 == 0)
                    {
                        for (int i = 0; i < Lenemy2.Count; i++)
                        {
                            Lenemy2[i].img = new Bitmap("e22.bmp");
                            Lenemy2[i].img.MakeTransparent(Lenemy2[i].img.GetPixel(Lenemy2[i].img.Width - 1, 0));
                        }
                    }
                    if (CountTicks2 % 110 == 0)
                    {
                        for (int i = 0; i < Lenemy2.Count; i++)
                        {
                            Lenemy2[i].img = new Bitmap("e33.bmp");
                            Lenemy2[i].img.MakeTransparent(Lenemy2[i].img.GetPixel(Lenemy2[i].img.Width - 1, 0));
                        }
                    }
                    if (CountTicks2 % 1 == 0)
                    {
                        for (int i = 0; i < Lrosas2.Count; i++)
                        {
                            Lrosas2[i].X -= Lrosas2[i].dx;
                            Lrosas2[i].Y -= Lrosas2[i].dy;
                        }
                    }
                }


                //enemy3
                if (flag3 == 0)
                {
                    if (CountTicks3 % 220 == 0)
                    {
                        CreateEnemy3();
                        flag3 = 1;
                    }

                }

                if (CountTicks3 % 225 == 0)
                {
                    for (int i = 0; i < Lenemy3.Count; i++)
                    {
                        Lenemy3[i].img = new Bitmap("e222.bmp");
                        Lenemy3[i].img.MakeTransparent(Lenemy3[i].img.GetPixel(Lenemy3[i].img.Width - 1, 0));
                    }

                }
                if (hero.Y == 170)
                {
                    if (CountTicks3 % 100 == 0)
                    {
                        CreateRosas3();

                    }

                    if (CountTicks3 % 105 == 0)
                    {
                        for (int i = 0; i < Lenemy3.Count; i++)
                        {
                            Lenemy3[i].img = new Bitmap("e333.bmp");
                            Lenemy3[i].img.MakeTransparent(Lenemy3[i].img.GetPixel(Lenemy3[i].img.Width - 1, 0));
                        }
                    }
                    if (CountTicks3 % 110 == 0)
                    {
                        for (int i = 0; i < Lenemy3.Count; i++)
                        {
                            Lenemy3[i].img = new Bitmap("e444.bmp");
                            Lenemy3[i].img.MakeTransparent(Lenemy3[i].img.GetPixel(Lenemy3[i].img.Width - 1, 0));
                        }
                    }
                    if (CountTicks3 % 115 == 0)
                    {
                        for (int i = 0; i < Lenemy3.Count; i++)
                        {
                            Lenemy3[i].img = new Bitmap("e555.bmp");
                            Lenemy3[i].img.MakeTransparent(Lenemy3[i].img.GetPixel(Lenemy3[i].img.Width - 1, 0));
                        }
                    }
                    if (CountTicks3 % 120 == 0)
                    {
                        for (int i = 0; i < Lenemy3.Count; i++)
                        {
                            Lenemy3[i].img = new Bitmap("e666.bmp");
                            Lenemy3[i].img.MakeTransparent(Lenemy3[i].img.GetPixel(Lenemy3[i].img.Width - 1, 0));
                        }
                    }
                    if (CountTicks3 % 1 == 0)
                    {
                        for (int i = 0; i < Lrosas3.Count; i++)
                        {
                            Lrosas3[i].X -= Lrosas3[i].dx;
                            Lrosas3[i].Y -= Lrosas3[i].dy;
                        }
                    }
                }



                //HeroBytl3Ladder
                if (CountTicks1 % 1 == 0)
                {
                    for (int i = 0; i < Lhero.Count; i++)
                    {
                        if (Lhero[i].X > Lladder[0].X && Lhero[i].X < Lladder[0].X + Lladder[0].W && Lhero[i].Y <= 600 && Lhero[i].Y > Lground[0].Y - 130)
                        {
                            Lhero[i].Y -= Lhero[i].dy;
                        }
                    }
                }

                //HeroBytl3Elevator
                if (CountTicks1 % 1 == 0)
                {
                    for (int i = 0; i < Lhero.Count; i++)
                    {
                        if (Lhero[i].X > Lelevator[0].X && Lhero[i].X < Lelevator[0].X + Lelevator[0].W && Lhero[i].Y <= 600 && Lhero[i].Y > Lground[1].Y - 130)
                        {
                            Lhero[i].Y = Lelevator[0].Y - hero.H;
                        }
                    }


                    for (int i = 0; i < Lelevator.Count; i++)
                    {
                        if (ct5 <= 200)
                        {
                            Lelevator[i].Y -= Lelevator[i].dy;
                        }

                        if (ct5 > 200 && ct5 <= 400)
                        {
                            Lelevator[i].Y += Lelevator[i].dy;
                        }

                        if (ct5 == 401)
                        {
                            ct5 = 0;
                        }
                    }
                }

                //HeroJump
                if (flagjump == 1)
                {
                    for (int i = 0; i < Lhero.Count; i++)
                    {
                        //Lhero[i].X += Lhero[i].dx;

                        if (CountTicks4 % 1 == 0)
                        {
                            Lhero[i].img = new Bitmap("111.bmp");

                            Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                        }

                        if (CountTicks4 % 2 == 0)
                        {
                            Lhero[i].img = new Bitmap("222.bmp");

                            Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                        }

                        if (CountTicks4 % 3 == 0)
                        {
                            Lhero[i].img = new Bitmap("333.bmp");

                            Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                        }

                        if (CountTicks4 % 4 == 0)
                        {
                            Lhero[i].img = new Bitmap("444.bmp");

                            Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                        }

                        if (CountTicks4 % 5 == 0)
                        {
                            Lhero[i].img = new Bitmap("555.bmp");

                            Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                        }

                        if (CountTicks4 % 6 == 0)
                        {
                            Lhero[i].img = new Bitmap("666.bmp");

                            Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                        }

                        if (CountTicks4 % 7 == 0)
                        {
                            Lhero[i].img = new Bitmap("777.bmp");

                            Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                        }

                        if (CountTicks4 % 8 == 0)
                        {
                            Lhero[i].img = new Bitmap("888.bmp");

                            Lhero[i].img.MakeTransparent(Lhero[i].img.GetPixel(Lhero[i].img.Width - 1, 0));
                        }


                        flagjump = 0;

                    }
                }

                //rosashero
                if (CountTicks4 % 1 == 0)
                {
                    for (int j = 0; j < LrosasHero.Count; j++)
                    {
                        LrosasHero[j].X += LrosasHero[j].dx;
                    }
                }

                if (CountTicks4 % 1 == 0)
                {
                    for (int i = 0; i < Lflag.Count; i++)
                    {
                        if (hero.X + hero.W >= Lflag[0].X && Lflag[0].Y > amod.Y)
                        {
                            Lflag[0].Y -= Lflag[0].dy;

                            
                            
                        }
                        

                    }
                }

                if (flag.Y == 110)
                {
                    flagKber = 3;
                   
                }

                this.Text = flagKber + "/";



                CountTicks1++;
                CountTicks2++;
                CountTicks3++;
                ct5++;
                CountTicks4++;

                
            }
            DrawDubb(this.CreateGraphics());
        }

        void DrawScene(Graphics g2) 
        {
            g2.Clear(Color.Black);

            for (int i = 0; i < Lminu.Count; i++)
            {
                g2.DrawImage(Lminu[i].img, Lminu[i].X, Lminu[i].Y, Lminu[i].W, Lminu[i].H);

            }


            for (int i = 0; i < Lgameover.Count; i++)
            {
                g2.DrawImage(Lgameover[i].img, Lgameover[i].X, Lgameover[i].Y, Lgameover[i].W, Lgameover[i].H);

            }

            for (int i = 0; i < Lbackground.Count; i++)
            {
                g2.DrawImage(Lbackground[i].img, Lbackground[i].rcDst, Lbackground[i].rcSrc,GraphicsUnit.Pixel);

            }

            for (int i = 0; i < Lground.Count; i++)
            {
                g2.DrawImage(Lground[i].img, Lground[i].X, Lground[i].Y, Lground[i].W, Lground[i].H);

            }

            for (int i = 0; i < Lladder.Count; i++)
            {
                g2.DrawImage(Lladder[i].img, Lladder[i].X, Lladder[i].Y, Lladder[i].W, Lladder[i].H);

            }

            for (int i = 0; i < Lelevator.Count; i++)
            {
                g2.DrawImage(Lelevator[i].img, Lelevator[i].X, Lelevator[i].Y, Lelevator[i].W, Lelevator[i].H);

            }

            for (int i = 0; i < Lamod.Count; i++)
            {
                g2.DrawImage(Lamod[i].img, Lamod[i].X, Lamod[i].Y, Lamod[i].W, Lamod[i].H);

            }

            for (int i = 0; i < Lflag.Count; i++)
            {
                g2.DrawImage(Lflag[i].img, Lflag[i].X, Lflag[i].Y, Lflag[i].W, Lflag[i].H);

            }

            for (int i = 0; i < Lhero.Count; i++)
            {
                g2.DrawImage(Lhero[i].img, Lhero[i].X, Lhero[i].Y, Lhero[i].W, Lhero[i].H);

            }

            for (int i = 0; i < LrosasHero.Count; i++)
            {
                g2.DrawImage(LrosasHero[i].img, LrosasHero[i].X, LrosasHero[i].Y, LrosasHero[i].W, LrosasHero[i].H);

            }

            for (int i = 0; i < LlezarHero.Count; i++)
            {
                g2.DrawImage(LlezarHero[i].img, LlezarHero[i].X, LlezarHero[i].Y, LlezarHero[i].W, LlezarHero[i].H);

            }

            for (int i = 0; i < LlezarLogo.Count; i++)
            {
                g2.DrawImage(LlezarLogo[i].img, LlezarLogo[i].X, LlezarLogo[i].Y, LlezarLogo[i].W, LlezarLogo[i].H);

            }

            for (int i = 0; i < LheartLogo.Count; i++)
            {
                g2.DrawImage(LheartLogo[i].img, LheartLogo[i].X, LheartLogo[i].Y, LheartLogo[i].W, LheartLogo[i].H);

            }

            for (int i = 0; i < Lenemy1.Count; i++)
            {
                g2.DrawImage(Lenemy1[i].img, Lenemy1[i].X, Lenemy1[i].Y, Lenemy1[i].W, Lenemy1[i].H);

            }

            for (int i = 0; i < Lenemy2.Count; i++)
            {
                g2.DrawImage(Lenemy2[i].img, Lenemy2[i].X, Lenemy2[i].Y, Lenemy2[i].W, Lenemy2[i].H);

            }

            for (int i = 0; i < Lenemy3.Count; i++)
            {
                g2.DrawImage(Lenemy3[i].img, Lenemy3[i].X, Lenemy3[i].Y, Lenemy3[i].W, Lenemy3[i].H);

            }

            for (int i = 0; i < Lrosas1.Count; i++)
            {
                g2.DrawImage(Lrosas1[i].img, Lrosas1[i].X, Lrosas1[i].Y, Lrosas1[i].W, Lrosas1[i].H);

            }

            for (int i = 0; i < Lrosas2.Count; i++)
            {
                g2.DrawImage(Lrosas2[i].img, Lrosas2[i].X, Lrosas2[i].Y, Lrosas2[i].W, Lrosas2[i].H);

            }

            for (int i = 0; i < Lrosas3.Count; i++)
            {
                g2.DrawImage(Lrosas3[i].img, Lrosas3[i].X, Lrosas3[i].Y, Lrosas3[i].W, Lrosas3[i].H);

            }

            for (int i = 0; i < Lsafe.Count; i++)
            {
                g2.DrawImage(Lsafe[i].img, Lsafe[i].X, Lsafe[i].Y, Lsafe[i].W, Lsafe[i].H);

            }
        }

        void DrawDubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawDubb(e.Graphics);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);

            CreateMinu();
            
        }
    }
}
