<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="description" content="MyLearnMate 1.0: " />
<meta name="keywords" content="education,school, english, mathematics, science, datamining,datamining tools,data mining tools,machine learning," />
<META NAME="ROBOTS" CONTENT="INDEX,FOLLOW">

<title>MyLearnMate 1.0 Beta</title>

<link rel="stylesheet" type="text/css" href="css/main.css" />
<link rel="stylesheet" type="text/css" href="css/style.css" />
<LINK REL='SHORTCUT ICON' HREF='http://www.dataminingtools.net/favicon.ico'>


<script language="javascript" type="text/javascript" src="js/jquery.js"></script>
<script type="text/javascript" src="js/jquery.watermark-2.0.min.js"></script> 
<script type="text/javascript" language="javascript" src="js/watermark.js"></script>
<script type="text/javascript" src="flowplayer/flowplayer-3.1.4.min.js"></script>
<script type="text/javascript" src="js/jquery.innerfade.js"></script>
<script type="text/javascript" src="js/AC_RunActiveContent.js"></script>
 
<script type="text/javascript">
var gaJsHost = (("https:" == document.location.protocol) ? "https://ssl." : "http://www.");
document.write(unescape("%3Cscript src='" + gaJsHost + "google-analytics.com/ga.js' type='text/javascript'%3E%3C/script%3E"));
</script>
<script type="text/javascript">
try {
var pageTracker = _gat._getTracker("UA-7668571-5");
pageTracker._trackPageview();
} catch(err) {}</script>

<script type="text/javascript">
var uservoiceOptions = {
  /* required */
  key: 'dataminingtools',
  host: 'dataminingtools.uservoice.com', 
  forum: '38099',
  showTab: true,  
  /* optional */
  alignment: 'left',
 background_color:'#06c'
, 
  text_color: 'white',
  hover_color: '#F06E20',
  lang: 'en'
};

function _loadUserVoice() {
  var s = document.createElement('script');
  s.setAttribute('type', 'text/javascript');
  s.setAttribute('src', ("https:" == document.location.protocol ? "https://" : "http://") + "cdn.uservoice.com/javascripts/widgets/tab.js");
  document.getElementsByTagName('head')[0].appendChild(s);
}
_loadSuper = window.onload;
window.onload = (typeof window.onload != 'function') ? _loadUserVoice : function() { _loadSuper(); _loadUserVoice(); };
</script>

<script language="JavaScript1.1">
<!--
var slideimages=new Array()
var slidelinks=new Array()
function slideshowimages(){
for (i=0;i<slideshowimages.arguments.length;i++){
slideimages[i]=new Image()
slideimages[i].src=slideshowimages.arguments[i]
}
}

function slideshowlinks(){
for (i=0;i<slideshowlinks.arguments.length;i++)
slidelinks[i]=slideshowlinks.arguments[i]
}

function gotoshow(){
if (!window.winslide||winslide.closed)
winslide=window.open(slidelinks[whichlink])
else
winslide.location=slidelinks[whichlink]
winslide.focus()
}

//-->
</script>
<script language="JavaScript" type="text/JavaScript">
<!--
function MM_reloadPage(init) {  //reloads the window if Nav4 resized
  if (init==true) with (navigator) {if ((appName=="Netscape")&&(parseInt(appVersion)==4)) {
    document.MM_pgW=innerWidth; document.MM_pgH=innerHeight; onresize=MM_reloadPage; }}
  else if (innerWidth!=document.MM_pgW || innerHeight!=document.MM_pgH) location.reload();
}
MM_reloadPage(true);
//-->
</script>

 <script type="text/javascript">
	   $(document).ready(
				function(){
					$('#news').innerfade({
						animationtype: 'slide',
						timeout: 5000,
						type: 'random',
						containerheight: '1.8em'
						
					}); 
				});
		</script>			

<style type="text/css">
.watermark {
	color: #999 !important;
}

/* Listen */
ul#news {
	list-style:none;
	background:url(images/newsbg.png) no-repeat;
	
	
}

ul#news li {
font-size:11px;
color:#A6A6A6;
padding:8px 0 5px 0;
}

ul#news li a {
color:#F9B40E;
margin-left:70px;
}

ul#news a:link {
	color: #F9B40E;
	text-decoration: none;
}

ul#news a:visited {
 /*	color: #3a7ec3;*/
	text-decoration: none;
}

ul#news a:hover,
ul#news a:active {
	color: #fff;
	text-decoration:underline;
}


</style> 

</head>

<body>

<div id="Layer6" style="position:absolute; left:72px; top:14px; width:897px; height:165px; z-index:6"><div id="masthead">
<?php  if(isset($_COOKIE["username"]))
  include("headerlogin.php")  ;
  
  else
  {
   include_once('header.php'); 
  }  ?>
</div></div>
<div id="Layer7" style="position:absolute; left:73px; top:899px; width:892px; height:308px; z-index:7"><div>
<?php include("footer.php");?></div></div>
<div id="Layer1" style="position:absolute; left:71px; top:180px; width:894px; height:1017px; z-index:8">
<iframe width="100%" height="100%" scrolling="no" frameborder="0" src="MYLEARNMATE.html"></iframe>

</div>
</body>
</html>
