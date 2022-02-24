﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoTuong
{
    class VanCo
    {
        public static NguoiChoi[] player = new NguoiChoi[2];
        public static bool DangChoi = false;
        public static int LuotDi = 0;
        public static bool isMarked = false; //  kiem tra da chon quan co hay chua 
        public static QuanCo.QuanCo temp;// de tham chieu den quuan co duoc chon trong 1 nuoc di chuyen
        public static Bitmap BackBuffer = null;
        public static bool isWin = false;
        static VanCo()
        {
            player[0] = new NguoiChoi(0);
            player[1] = new NguoiChoi(1);
        }
        public static void NewGame()
        {
            if (DangChoi)
            {
                // xoa quan cho tren ban co 
                for(int i =0; i<2; i++)
                {
                    player[0].qXe[i].picQuanCo.Visible = false;
                    player[0].qMa[i].picQuanCo.Visible = false;
                    player[0].qVoi[i].picQuanCo.Visible = false;
                    player[0].qSi[i].picQuanCo.Visible = false;
                    player[0].qPhao[i].picQuanCo.Visible = false;
                }
                for (int i = 0; i < 5; i++)
                    player[0].qTot[i].picQuanCo.Visible = false;
                player[0].qTuong.picQuanCo.Visible = false;
                //=========================================
                for (int i = 0; i < 2; i++)
                {
                    player[1].qXe[i].picQuanCo.Visible = false;
                    player[1].qMa[i].picQuanCo.Visible = false;
                    player[1].qVoi[i].picQuanCo.Visible = false;
                    player[1].qSi[i].picQuanCo.Visible = false;
                    player[1].qPhao[i].picQuanCo.Visible = false;
                }
                for (int i = 0; i < 5; i++)
                    player[1].qTot[i].picQuanCo.Visible = false;
                player[1].qTuong.picQuanCo.Visible = false;

                // xoa hai ng choi
                Array.Resize<CoTuong.NguoiChoi>(ref player, 0);
                // khoi tao lai hai ng choi
                Array.Resize<CoTuong.NguoiChoi>(ref player, 2);
                player[0] = new NguoiChoi(0);
                player[1] = new NguoiChoi(1);
                // khoi tao ban co
                BanCo.ResetBanCo();
                LuotDi = 0;
                // dat quan co vao vi tri
                for (int i = 0; i < 2; i++)
                {
                    player[0].qXe[i].draw();
                    player[0].qMa[i].draw();
                    player[0].qVoi[i].draw();
                    player[0].qSi[i].draw();
                    player[0].qPhao[i].draw();
                }
                for (int i = 0; i < 5; i++)
                    player[0].qTot[i].draw();
                player[0].qTuong.draw();

                //=======================
                for (int i = 0; i < 2; i++)
                {
                    player[1].qXe[i].draw();
                    player[1].qMa[i].draw();
                    player[1].qVoi[i].draw();
                    player[1].qSi[i].draw();
                    player[1].qPhao[i].draw();
                }
                for (int i = 0; i < 5; i++)
                    player[1].qTot[i].draw();
                player[1].qTuong.draw();
            }
            else
            {
                // tao ban co trong
                BanCo.ResetBanCo();
                VanCo.DangChoi = true;
                // dat quan co vao vi tri
                for (int i = 0; i < 2; i++)
                {
                    player[0].qXe[i].draw();
                    player[0].qMa[i].draw();
                    player[0].qVoi[i].draw();
                    player[0].qSi[i].draw();
                    player[0].qPhao[i].draw();
                }
                for (int i = 0; i < 5; i++)
                    player[0].qTot[i].draw();
                player[0].qTuong.draw();
                //========================
                for (int i = 0; i < 2; i++)
                {
                    player[1].qXe[i].draw();
                    player[1].qMa[i].draw();
                    player[1].qVoi[i].draw();
                    player[1].qSi[i].draw();
                    player[1].qPhao[i].draw();
                }
                for (int i = 0; i < 5; i++)
                    player[1].qTot[i].draw();
                player[1].qTuong.draw();
            }

        }
        public static void DoiLuotDi()
        {
            if (LuotDi == 0) LuotDi = 1;
            else if(LuotDi == 1) LuotDi = 0;
            if(VanCo.LuotDi == 0)
            {
                for (int i = 0; i < 2; i++)
                {
                    player[0].qXe[i].isLock = false;
                    player[0].qMa[i].isLock = false;
                    player[0].qVoi[i].isLock = false;
                    player[0].qSi[i].isLock = false;
                    player[0].qPhao[i].isLock = false;
                }
                for (int i = 0; i < 5; i++)
                    player[0].qTot[i].isLock = false;
                player[0].qTuong.isLock = false;

                //khoa quan co lai
                for (int i = 0; i < 2; i++)
                {
                    player[1].qXe[i].isLock = true;
                    player[1].qMa[i].isLock = true;
                    player[1].qVoi[i].isLock = true;
                    player[1].qSi[i].isLock = true;
                    player[1].qPhao[i].isLock = true;
                }
                for (int i = 0; i < 5; i++)
                    player[1].qTot[i].isLock = true;
                player[1].qTuong.isLock = true;
            }
            else if(LuotDi == 1)
            {


                for (int i = 0; i < 2; i++)
                {
                    player[1].qXe[i].isLock = false;
                    player[1].qMa[i].isLock = false;
                    player[1].qVoi[i].isLock = false;
                    player[1].qSi[i].isLock = false;
                    player[1].qPhao[i].isLock = false;
                }
                for (int i = 0; i < 5; i++)
                    player[1].qTot[i].isLock = false;
                player[1].qTuong.isLock = false;
                //==========================
                for (int i = 0; i < 2; i++)
                {
                    player[0].qXe[i].isLock = true;
                    player[0].qMa[i].isLock = true;
                    player[0].qVoi[i].isLock = true;
                    player[0].qSi[i].isLock = true;
                    player[0].qPhao[i].isLock = true;
                }
                for (int i = 0; i < 5; i++)
                    player[0].qTot[i].isLock = true;
                player[0].qTuong.isLock = true;
            }
        }
        public static void setOCoTrong(int row, int col)
        {
            BanCo.ViTri[row, col].Trong = true;
            BanCo.ViTri[row, col].Ten = "";
            BanCo.ViTri[row, col].Phia = "";
            BanCo.ViTri[row, col].Phe = 2;
        }
        public static void DatQuanCo(Object sender, QuanCo.QuanCo qc, int row, int col)
        {
            //  dat quan co len ban co 
            if(sender.GetType() == typeof(CoTuong.fBanCo))
            {
                qc.Hang = row;
                qc.Cot = col;
                qc.draw();
            }
            // dat quan co len 1 quan co khac 
            if(sender.GetType() == typeof(System.Windows.Forms.PictureBox))
            {
                BanCo.ViTri[row, col].Trong = false;
                BanCo.ViTri[row, col].Phe = temp.Phe;
                BanCo.ViTri[row, col].Ten = temp.Ten;
                BanCo.ViTri[row, col].Phia = temp.Phia;
                temp.Hang = row;
                temp.Cot = col;
                temp.picQuanCo.Top = row * 50 + 35;
                temp.picQuanCo.Left = col * 50 + 10;
            }
        }
        public static void AnQuanCo(QuanCo.QuanCo qc)
        {
            qc.TrangThai = 0;
            qc.picQuanCo.Cursor = Cursors.Arrow;
            qc.picQuanCo.Top = 5000;
            qc.picQuanCo.Left = 6000;
        }


    }
}