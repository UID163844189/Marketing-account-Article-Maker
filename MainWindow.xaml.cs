using System;
using System.Collections.Generic;
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

namespace 营销号生成器
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Mode1()
		{
			
			/*营销号的文案：
			 *ab是什么呢？对于a，我们很熟悉，但是最近有一个说法是“ab”，这是什么呢？
			 *下面就跟着小编一起来看一下吧。\n
			 *ab，其实就是c。大家可能会很惊讶：ab怎么会是c呢？但是事实就是这样的，小编也不明白。\n
			 *那么对于ab是c，你有什么想法呢？欢迎在评论区留言告诉小编哦。\n
			 *点个“在看”，让更多人知道ab是c这骇人听闻的事实↓
			 */
			Out.Text = Key1.Text + Key2.Text + "是什么呢？" +
				"对于" + Key1.Text + "，" +
				"我们很熟悉，" +
				"但是最近有一个说法是“" + Key1.Text + Key2.Text + "”," +
				"这是什么呢？下面就跟着小编一起来看一下吧。\n" +

				Key1.Text + Key2.Text + "，其实就是" + Key3.Text +
				"。大家可能会很惊讶：" + Key1.Text + Key2.Text + "怎么会是" + Key3.Text + "呢？" +
				"但是事实就是这样的，小编也不明白。\n" +

				"那么对于" + Key1.Text + Key2.Text + "是" + Key3.Text +
				"，你有什么想法呢？欢迎在评论区留言告诉小编哦。\n" +

				"点个“在看”，让更多人知道" + Key1.Text + Key2.Text + "就是" + Key3.Text +
				"这骇人听闻的事实↓";
		}

		private void Mode2()
		{

			/*文案：
			 * a是什么呢？相信大家对b已经很熟悉，但是最近有一种说法叫“a”，那么a是什么呢？
			 * 下面就跟着小编来一起一探究竟吧。\n
			 * a，其实就是b。大家可能会好奇：a怎么会是b呢？但是事实就是这样的，小编也不明白。\n
			 * 那么对于a是b，你有什么想法呢？欢迎在评论区留言告诉小编哦。\n
			 * 点个“在看”，让更多人知道a是b这骇人听闻的事实↓
			 */
			Out.Text = Key2.Text + "是什么呢？" +
				"对于" + Key3.Text + "，" +
				"我们很熟悉，" +
				"但是最近有一个说法是“" + Key2.Text + "”," +
				"这是什么呢？下面就跟着小编一起来看一下吧。\n" +

				Key2.Text + "，其实就是" + Key3.Text +
				"。大家可能会很惊讶：" + Key2.Text + "怎么会是" + Key3.Text + "呢？" +
				"但是事实就是这样的，小编也不明白。\n" +

				"那么对于" + Key2.Text + "是" + Key3.Text +
				"，你有什么想法呢？欢迎在评论区留言告诉小编哦。\n" +

				"点个“在看”，让更多人知道" + Key2.Text + "就是" + Key3.Text +
				"这骇人听闻的事实↓";
		}

		private void Mode3()
		{
			/*文案：
			 * a是什么呢？相信大家对b已经很熟悉，但是最近有一种说法叫“a”，那么a是什么呢？
			 * 下面就跟着小编来一起一探究竟吧。\n
			 * a，其实就是bc。大家可能会好奇：a怎么会是bc呢？但是事实就是这样的，小编也不明白。\n
			 * 那么对于a是bc，你有什么想法呢？欢迎在评论区留言告诉小编哦。\n
			 * 点个“在看”，让更多人知道a是bc这骇人听闻的事实↓
			 */
			Out.Text = Key1.Text + "是什么呢？" +
				"对于" + Key3.Text + "，" +
				"我们很熟悉，" +
				"但是最近有一个说法是“" + Key1.Text + "”," +
				"这是什么呢？下面就跟着小编一起来看一下吧。\n" +

				Key1.Text + "，其实就是" + Key3.Text + Key4.Text +
				"。大家可能会很惊讶：" + Key1.Text + "怎么会是" + Key3.Text + Key4.Text + "呢？" +
				"但是事实就是这样的，小编也不明白。\n" +

				"那么对于" + Key1.Text + "是" + Key3.Text + Key4.Text +
				"，你有什么想法呢？欢迎在评论区留言告诉小编哦。\n" +

				"点个“在看”，让更多人知道" + Key1.Text + "就是" + Key3.Text + Key4.Text +
				"这骇人听闻的事实↓";
		}

		private void Copy_Click(Object sender, RoutedEventArgs e)
		{
			Clipboard.SetDataObject(Out.Text);
		}

		private void Make_Click(Object sender, RoutedEventArgs e)
		{
			if (Type1.IsChecked == true) { Mode1(); }
			else if (Type2.IsChecked == true) { Mode2(); }
			else if (Type3.IsChecked == true) { Mode3(); }
			else { MessageBox.Show("请选定一种生成方式"); }
		}

		private void Type1_Checked(Object sender, RoutedEventArgs e)
		{
			Key1.IsEnabled = true;
			Key2.IsEnabled = true;
			Key3.IsEnabled = true;
			Key4.IsEnabled = false;
		}

		private void Type2_Checked(Object sender, RoutedEventArgs e)
		{
			Key1.IsEnabled = false;
			Key2.IsEnabled = true;
			Key3.IsEnabled = true;
			Key4.IsEnabled = false;
		}

		private void Type3_Checked(object sender, RoutedEventArgs e)
		{
			Key1.IsEnabled = true;
			Key2.IsEnabled = false;
			Key3.IsEnabled = true;
			Key4.IsEnabled = true;
		}
	}
}
