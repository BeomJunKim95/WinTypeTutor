using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinTypeTutor
{
	public partial class Form1 : Form
	{
		List<string> listSentence = new List<string>();
		int chance = 10; //초기기회 10번
		int score = 0; 
		int scoreAdd = 200; // 한문제 맞출때마다 200점씩 추가

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//메뉴를 클릭할때마다 파일을 읽어오는 것은 지금은 상관없지만 데이터가 커지면 소모가 너무커짐
			//그래서 Load에 코딩하는게 좋음

			//파일을 읽어서 List변수에 저장
			StreamReader sr = new StreamReader("data/typedata.txt"); //절대경로 말고 상대경로로 하는게 좋다
			// 1. 폴더를 추가하고 파일을 폴더에 넣는다
			// 2. 폴더에 넣은 파일의 속성에서 <출력 디렉토리에 복사> 를 항상 복사로 바꿔준다
			string temp;
			while((temp = sr.ReadLine()) != null)
			{
				listSentence.Add(temp);
			}
			sr.Close();

			//컨트롤의 초기화
			//lblScore.Text = score.ToString();
			//lblChance.Text = chance.ToString();
			//lblScore.Text = "";
			lblScore.Text = lblChance.Text = lblScore.Text = "";
			//처음에 아무것도 출력안한 상태로 만들고 싶을때 이렇게 한줄로가능
			txtAnswer.Enabled = false;


		}

		private void 시작ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			//progressBar컨트롤 값을 100으로 초기화 
			//문제를 난수발생으로 뽑아서 라벨에 보여주기
			//문제를 쓰다가 지나가면 텍스트 박스 초기화
			//이것을 메서드로 통일
			DisplaySentence();
			
		}

		private void DisplaySentence()
		{
			//progressBar컨트롤 값을 100으로 초기화 
			progressBar1.Value = 100;

			//문제를 난수발생으로 뽑아서 라벨에 보여주기
			Random rnd = new Random();
			int i = rnd.Next(0, listSentence.Count);
			lblSentence.Text = listSentence[i];
			
			//컨트롤 초기화
			lblScore.Text = score.ToString();
			lblChance.Text = chance.ToString();

			//문제를 쓰다가 지나가면 텍스트 박스 초기화
			txtAnswer.Enabled = true;

			//txtAnswer.ImeMode = ImeMode.Hangul; // 속성으로 주지않고 코딩으로 주는방법
			//txtAnswer.Text = "";
			txtAnswer.Clear();//속성 메서드 사용해도 가능
			txtAnswer.Select(0, 0);//텍스트박스의 텍스트 범위 설정
			txtAnswer.Focus();//포커스 설정 
			//Focus 커서만 그냥 가져다주는 역할
			//글씨가 입력중에 넘어가면 버퍼에 쓰던게 남아있기때문에 Select메서드를 이용해 0,0으로 범위설정해줘서 해결(미해결)

			timer1.Stop();// 문제를 입력하지 않아도 시간이 계속 가는 상황을 해결하기 위해
		}

		private void txtAnswer_TextChanged(object sender, EventArgs e)
		{
			//텍스트박스에 문제를 입력할때부터 시간이 가는 이벤트 등록
			timer1.Interval = 1000; //1000이 1초
			timer1.Start();
		}

		private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
		{
			//엔터 입력시의 상황
			if(e.KeyChar == 13) // 13이 엔터
			{
				timer1.Stop();
				if(lblSentence.Text.Equals(txtAnswer.Text))
				{
					//문제를 맞혔을시
					score += scoreAdd;
				}
				else
				{
					//틀렸을시
					chance--;
					if(chance == 0)
					{
						//MessageBox.Show("게임 종료");

						//종료되었을시 재시작하는지 물어보기위한 코드
						DialogResult result = MessageBox.Show("게임이 종료되었습니다. 다시 하시겠습니까?", "재시작 확인", MessageBoxButtons.YesNo);
						if( result == DialogResult.Yes)
						{
							score = 0;
							chance = 10;
							DisplaySentence();
						}
						else
						{
							return;
						}
						//return; // 기회를 모두 소진하면 다음문제를 보여주지 않기 위해
					}
				}
				//맞히거나 틀리거나 다음문제를 보여줘야하기때문에 조건문 밖에서 호출
				DisplaySentence();
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			//반드시 프로그레스바의 밸류가 0아래로 내려갔을때의 상황 추가
			if (progressBar1.Value < 10)
			{
				progressBar1.Value = 0;
				timer1.Stop();

				chance--; // 시간 다지날때까지 못풀었다는거니까 찬스하나 빼기
				if (chance == 0)
				{
					//위에 KeyPress의 코드와 같이
					DialogResult result = MessageBox.Show("게임이 종료되었습니다. 다시 하시겠습니까?", "재시작 확인", MessageBoxButtons.YesNo);
					if (result == DialogResult.Yes)
					{
						score = 0;
						chance = 10;
						DisplaySentence();
					}
					else
					{
						return;
					}
				}
				else
				{
					DisplaySentence();
				}
			}
			else
			{
				progressBar1.Value -= 10;
			}
		}
	}
}
