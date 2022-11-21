using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jyankenbattle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //5-7まで

            //画面の初期化
            //手を選択できないようにする
            lockButton.Enabled = false;
            scissorsButton.Enabled = false;
            paperButton.Enabled = false;

        }

        private void lockButton_Click(object sender, EventArgs e)
        {
            // プレイヤーの手をグーにする
            var playerHand = JyankenHand.Rock;
            Battle(playerHand);
        }

        private void Battle(JyankenHand playerHand)
        {
            //プレイヤーの手に応じた画像をゲームエリアに表示する

            playerHandBox.Image = GetHandImage(playerHand);

            //敵の手をランダムに決める
            var random = new Random();
            var enemyHandValue = random.Next(0, 3);//0~2までのランダムな数値
            var enemyHand = (JyankenHand)enemyHandValue;//列挙型にキャスト
            //敵の手に応じた画像をゲームエリアに表示
            enemyHandBox.Image = GetHandImage(enemyHand);//enemyHandにはランダムの値が入っている。

            //勝敗を判定する
            JyankenResult jyankenResult;
            if (playerHand == enemyHand)
            {
                jyankenResult = JyankenResult.Even;
            }
            else if ((playerHand == JyankenHand.Rock && enemyHand == JyankenHand.Scissors) || (playerHand == JyankenHand.Scissors && enemyHand == JyankenHand.Paper) || (playerHand == JyankenHand.Paper && enemyHand == JyankenHand.Rock))
            {
                jyankenResult = JyankenResult.Win;//勝ち
            }
            else
            {
                jyankenResult = JyankenResult.Losing;//負け
            }
            switch (jyankenResult)
            {
                case JyankenResult.Even:
                    MessageBox.Show("あいこです");
                    break;
                case JyankenResult.Win:
                    MessageBox.Show("勝ちです");
                    break;
                case JyankenResult.Losing:
                    MessageBox.Show("負けです");
                    break;
                default:
                    break;
            }
        }

        private static Image GetHandImage(JyankenHand hand)//staticとつけるとクラスメソッドになる。
        {
            

            Image handImage;
            if (hand == JyankenHand.Rock)
            {
                handImage = Properties.Resources.rock;
            }
            else if (hand == JyankenHand.Scissors)//チョキの画像を表示
            {
                handImage = Properties.Resources.scissors;
            }
            else
            {
                handImage = Properties.Resources.paper;//パーの画像を表示
            }
         

            return handImage;
        }

      

        private void paperButton_Click(object sender, EventArgs e)
        {
            // プレイヤーの手パーにする
            var playerHand = JyankenHand.Paper;
            Battle(playerHand);
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            // プレイヤーの手をチョキにする
            var playerHand = JyankenHand.Scissors;
            Battle(playerHand);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            lockButton.Enabled = true;
            scissorsButton.Enabled = true;
            paperButton.Enabled = true;

            playerHandBox.Image = null;
            enemyHandBox.Image = null;

            MessageBox.Show("ゲームスターと");
        }
    }
}
