head>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<link rel="stylesheet" href="style.css">
</head>

<?php
$db_user = 'u47560';
$db_pass = '7678381';
$db = new PDO('mysql:host=localhost;dbname=u47560', $db_user, $db_pass, array(
    PDO::ATTR_PERSISTENT => true
));
$login = isset($_SERVER['PHP_AUTH_USER']) ? $_SERVER['PHP_AUTH_USER'] : '';
$stmt = $db->prepare("SELECT * FROM admin WHERE login = ?");
      $stmt->execute(array(
        $login
      ));
$admin_pass = $stmt->fetch();

if (empty($_SERVER['PHP_AUTH_USER']) ||
 empty($_SERVER['PHP_AUTH_PW']) ||
 $_SERVER['PHP_AUTH_USER'] != 'admin' ||
 $_SERVER['PHP_AUTH_PW'] != '123') {
 header('HTTP/1.1 401 Unauthorized');
 header('WWW-Authenticate: Basic realm="My site"');
 header('Content-Type: text/html; charset=UTF-8');
 print '<h1>401 Требуется авторизация</h1>';
      exit();
}

print('Вы успешно авторизовались и видите защищенные паролем данные!<br>');

function show_tables($db){
  $sql = 'SELECT  application.*, 
                    superdef.name as power,
                    username.login
            FROM application
            INNER JOIN supersss
                ON application.id = supersss.id
            INNER JOIN superdef 
                ON supersss.superpowers = superdef.id
            INNER JOIN username 
                ON username.id = application.id;';
  ?>
  <table class="table">
  <caption>Данные о пользователях</caption> 
    <tr>
        <th>ID</th>
        <th>имя</th>
        <th>e-mail</th>
        <th>дата рождения</th>
        <th>пол</th>
        <th>конечности</th>
        <th>биография</th>
        <th>суперспособности</th>
        <th>логин</th>
        <th colspan="3">действие</th>
    </tr>
  <?php
	  foreach ($db->query($sql, PDO::FETCH_ASSOC) as $row) {
      print('<tr>');
      foreach ($row as $v){
        print('<td>'.$v. '</td>');
      }
      print('<td colspan="2"> <a href="?act=edit_article&edit_id='.$row["id"].'">редактировать</a></td>   ');
      print('<td> <a href="?act=delete_article&delete_id='.$row["id"].'">удалить</a></td>');
    } 
    print('</tr></table>');
    print('<td> <a href="?act=add_article">добавить</a></td><br>');

    
    $sql = 'SELECT superdef.name as superpower, COUNT(superpowers) as number_of_users
            FROM supersss 
            LEFT JOIN superdef
            ON supersss.superpowers=superdef.id
            GROUP BY superpowers;';
    ?>
    <table class="table">
    <caption>Статистика суперспособностей:</caption> 
      <tr>
          <th>суперспособность:</th>
          <th>количество пользователей:</th>
        </tr>
    <?php
    foreach ($db->query($sql, PDO::FETCH_ASSOC) as $row) {
      print('<tr>');
      foreach ($row as $k=>$v){
	  	  print('<td>'.$v. '</td>');
      }
    }print('</tr></table>');
    print('<br><a href=login.php?do=logout> Выход</a><br>');
}
function form($db){
  ?>
  <label for='name'>Имя:</label>
      <input name='name'><br />
  <label for='email'>E-mail:</label>
      <input name='email'><br />
  <label for='date'>Дата рождения:</label>
      <input name='date'><br />
  <label>Пол:</label>
	  <input type="radio" value="male" name='gender'>мужской
	  <input type="radio" value="female" name='gender'>женский<br />
  
  <label>Конечности:</label>
	  <input type="radio" name='limbs' value='1'>1
	  <input type="radio" name='limbs' value='2'>2
	  <input type="radio" name='limbs' value='3'>3
	  <input type="radio" name='limbs' value='4'>4<br />
	  
	  <p>Суперспособности:</p>
      <label><select name="super[]" multiple="multiple">
        <?php
				$sql = 'SELECT * FROM superdef';
				foreach ($db->query($sql) as $row) {
					?><option value=<?php print $row['id']?> name=super[]>
					<?php print $row['name'] . "\t";
				}
			?></option>
		</select>
      </label><br />
	  
	  
	  
  <label for="bio">Биография:</label>
     <textarea name='bio'></textarea><br />

  <?php
}
function errors(){
  $errors = FALSE;
    // ИМЯ
    if (empty($_POST['name'])&&empty($_GET['edit_id'])) {
      $errors = TRUE;
    }
    else if(!empty($_POST['name'])&&!preg_match("/^[а-яё]|[a-z]$/iu", $_POST['name'])){
      $errors = TRUE;
    }
    // EMAIL
    if (empty($_POST['email'])&&empty($_GET['edit_id'])){
      $errors = TRUE;
    }
    else if(!empty($_POST['email'])&&!preg_match("/^[a-zA-Z0-9._-]+@[a-zA-Z0-9-]+.[a-zA-Z.]{2,5}$/", $_POST['email'])){
      $errors = TRUE;
    }
    // Дата
    if (empty($_POST['date'])&&empty($_GET['edit_id'])){
      $errors = TRUE;
    }
    // ПОЛ
    if (empty($_POST['gender'])&&empty($_GET['edit_id'])) {
      $errors = TRUE;
    }
    // КОНЕЧНОСТИ
    if (empty($_POST['limbs'])&&empty($_GET['edit_id'])) {
      $errors = TRUE;
    }
    // СУПЕРСПОСОБНОСТИ
    $super=array();
    if(empty($_POST['super'])&&empty($_GET['edit_id'])){
      $errors = TRUE;
    }
    else if(!empty($_POST['super'])){
      foreach ($_POST['super'] as $key => $value) {
        $super[$key] = $value;
      }
    }
    // ИНФОРМАЦИЯ О СЕБЕ
    if (empty($_POST['bio'])&&empty($_GET['edit_id'])) {
      $errors = TRUE;
    }
    if ($errors) {
      return true;
    }
    else{
      return false;
    }
}
function delete_user($db, $del){
  try{
    $sth = $db->prepare("DELETE FROM application WHERE id = ?");
    $sth->execute(array($del));
    $sth = $db->prepare("DELETE FROM supersss WHERE id = ?");
    $sth->execute(array($del));
    $sth = $db->prepare("DELETE FROM username WHERE id = ?");
    $sth->execute(array($del));
  }
  catch(PDOException $e){
    print('Error: ' . $e->getMessage());
    exit();
  }
}
function add_user($db){
  $sth = $db->prepare("SELECT login FROM username");
  $sth->execute();
  $login_array = $sth->fetchAll(PDO::FETCH_COLUMN);
  $flag=true;
  do{
    $login = rand(1,1000);
    $pass = rand(1,10000);
    foreach($login_array as $value){
      if($value == $login)
        $flag=false;
    }
  }while($flag==false);
  $hash = password_hash((string)$pass, PASSWORD_BCRYPT);
  
  try {
    $stmt = $db->prepare("INSERT INTO application SET name = ?, email = ?, date = ?, gender = ?, limbs = ?, bio = ?");
    $stmt -> execute(array(
        $_POST['name'],
        $_POST['email'],
        $_POST['date'],
        $_POST['gender'],
        $_POST['limbs'],
        $_POST['bio'],
      )
    );

    $id_db = $db->lastInsertId("application");
    $stmt = $db->prepare("INSERT INTO supersss SET id = ?, superpowers = ?");
    foreach($_POST['super'] as $s){
        $stmt -> execute(array(
          $id_db,
          $s,
        ));
      }
    $stmt = $db->prepare("INSERT INTO username SET login = ?, pass = ?");
    $stmt -> execute(array(
        $login,
        $hash,
      )
    );
  } 
  catch(PDOException $e){
    print('Error: ' . $e->getMessage());
    exit();
  }
}
function edit_user($db, $edit){
  try {
    $stmt = $db->prepare('SELECT * FROM application WHERE id=?');
    $stmt -> execute(array($edit));
    $a = array();
    $old_data = ($stmt->fetchAll(PDO::FETCH_ASSOC))['0'];
    foreach ($old_data as $key=>$val){
      $a[$key] = $val;
    }
    $name = empty($_POST['name']) ? $a['name'] : $_POST['name'];
    $email = empty($_POST['email']) ? $a['email'] : $_POST['email'];
    $date = empty($_POST['date']) ? $a['date'] : $_POST['date'];
    $gender = empty($_POST['gender']) ? $a['gender'] : $_POST['gender'];
    $limbs = empty($_POST['limbs']) ? $a['limbs'] : $_POST['limbs'];
    $bio = empty($_POST['bio']) ? $a['bio'] : $_POST['bio'];

    $stmt = $db->prepare("UPDATE application SET name = ?, email = ?, date = ?, gender = ?, limbs = ?, bio = ? WHERE id =?");
    $stmt -> execute(array(
        $name,
        $email,
        $date,
        $gender,
        $limbs,
        $bio,
        $edit
    ));
    if(!empty($_POST['super'])){
      $sth = $db->prepare("DELETE FROM supersss WHERE id = ?");
      $sth->execute(array($edit));
      $stmt = $db->prepare("INSERT INTO supersss SET id = ?, superpowers = ?");
      foreach($_POST['super'] as $s){
          $stmt -> execute(array(
            $edit,
            $s,
          ));
        }
    }
  }
  catch(PDOException $e){
    print('Error: ' . $e->getMessage());
    exit();
  }
}

if($_SERVER['REQUEST_METHOD'] == 'GET'){
  show_tables($db);
  if(isset($_GET['act'])&&$_GET['act']=='edit_article'){
    ?><form action="" method="post">
      <h4>редактировать профиль с ID=<?php print($_GET['edit_id']); ?></h4>
    <p>
      <?php form($db);?>
    </p>
    <p><button type="submit" value="send">отправить</button></p>
    </form>
    <?php
  }
  else if(isset($_GET['act'])&&$_GET['act']=='add_article'){
    ?><form action="" method="post">
      <h5>добавить профиль</h5>
    <p>
      <?php form($db);?>
    </p>
    <p><button type="submit" value="send">отправить</button></p>
    </form>
    <?php
     }
  else if(isset($_GET['act'])&&$_GET['act']=='delete_article'){
    ?>
    <form action="" method="post">
    <h4>удалить пользователя c ID=<?php print($_GET['delete_id']);?>?</h4>
    <p><button type="submit" value="send">ок</button></p>
    </form>
    <?php
    }
}
else{
  try {
    if(!empty($_GET['delete_id'])){delete_user($db, $_GET['delete_id']);}
    if(!empty($_GET['edit_id']))if(!errors()){edit_user($db, $_GET['edit_id']);}
    if(isset($_GET['act'])&&$_GET['act']=='add_article'){add_user($db);}
  }
  catch(PDOException $e) {
    echo 'Ошибка: ' . $e->getMessage();
    exit();
  }
  header('Location: admin.php');
}*
