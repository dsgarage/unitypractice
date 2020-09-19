# Unity Practice

* 拡張メソッド
* インターフェースの実装
* DI
* 抽象化


## Gitでまずやる事

* 新規リポジトリの設定
* 設定したリポジトリをプルかフェッチをする
* gitfllowの初期化(SorceTree)
* GitHubに戻って、Issueに作業内容を書く
* Issue番号でフューチャーリポジトリを作成
* 何かコミット→プッシュしてプルリクを作成
* 準備完了



## Windowsでのgit設定

WindowsでGitを始めたらまず確認！Git Bashの設定&ショートカット
https://www.granfairs.com/blog/staff/gitbash-setting-shortcut

https://www.karakaram.com/git-install/#check-sshkey <br>
<br>
GitHubに公開鍵認証方式でSSH接続する<br>
https://hacknote.jp/archives/56523/<br>
<br>
git pushでエラーが出たのでssh接続するための設定を行った<br>
https://hacknote.jp/archives/56513/<br>
<br>
git bashに「cd 」を入力し、プロジェクトファイルをドラッグ＆ドロップ<br>
Enter<br>
「vim config」と入力<br>
Enter<br>
Host github github.com<br>
  HostName github.com<br>
  IdentityFile ←ここに自分の作成した秘密鍵「id_rsa.pub」をD&D<br>
  User git<br>
入力したらEsc →　「:wq」の順に入力<br>
Enter<br>
(なぜか上書きされない場合があるので、その場合は直接id_rsa.pubをメモ帳として開き書き換える)<br>
「ssh -T github」と入力」<br>
Enter<br>



<br><br>
## 拡張メソッド
https://ufcpp.net/study/csharp/fun_WhyExtensions.html<br>
https://tech-lab.sios.jp/archives/15724<br>
<br>
## インターフェース
https://qiita.com/yutorisan/items/d28386f168f2f3ab166d

