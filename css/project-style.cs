.color-container{
	float:left;
	width:100%;
	overflow:hidden;
}
.color-box{
	width:20%;
	height:500px;
	position:relative;
	z-index:0;
	background-color:blue;
	float:left;
	transition-duration: .6s;
	z-index:1;
	overflow:hidden;
}
.color-box:active{
	position:relative;
	z-index:100;
	transform: scale(10,.6) translate(0,-180px);
	overflow:hidden;

}
.color-name-container{
	float:left;
	width:100%;
	position:relative;
	bottom:250px;
	z-index:101;
	pointer-events:none;
	border-top: .3rem solid rgba(200,200,200,20%);
}
.color-name-box{
	float:left;
	width:18%;
	background-color:blue;
	padding-left:2%;
	font-weight:bold;
	font-size:1.5rem;
	height:270px;
	transition:.3s;
}
.text-align-bottom{
	position:relative;
	top:75%x;
	line-height:150%;
	font-family:"BarlowCondensed";
	font-weight:600;
}
.color-palette{
	overflow:hidden;
	margin-bottom:-15%;
	width:100%;
}
.project-header{
	margin-bottom:10%;
	background-color:blue;
	background-image:url('');
	font-size:2rem;
	font-weight:bold;
	padding:2%;

}
.project-header-type{
	font-size:7rem;
}
.section-text{
	font-size:3rem;
	color:black;
	text-align:center;


}
.button {
	background-color:#efe00e;
	padding:.6% 3%;
	border-bottom:.6vw solid #eeeeee;
	font-size:1.25vw;
	transition:.1s;
	text-transform:uppercase;
	color:#000 !important; 
	text-decorations:none;
	font-weight:500;
	font-family:"BarlowCondensed";
}
.button:hover{
	background-color:#999;
	border-bottom:.6vw solid #010101;
	font-weight:700;
}


.uneven10{
	width:10%;
	float:left;
}
.uneven20{
        width:20%;
  float:left;
}
.uneven30{
        width:30%;
  float:left;
}
.uneven40{
        width:40%;
  float:left;
}
.uneven50{
        width:50%;
  float:left;
}
.uneven60{
        width:60%;
  float:left;
}
.uneven70{
        width:70%;
  float:left;
}
.uneven80{
        width:80%;
  float:left;
}
.uneven90{
        width:90%;
  float:left;
}
.uneven33{
	width:33%;
	float:left;
}
.unevencolumn {
	margin-bottom:10%;
	width:90%;
	margin-left:5%;
}
.text-box {
	width:95%;
	float:left;
	margin:0 2.5%;
}

.font-section {
font-size:1.75rem;
}

.image-section{
	width:100%;
	overflow:hidden;
}



@media screen and (max-width: 800px) {
.section-text{
	margin-left:3%;
	font-size:1rem;
}
.color-box{
	width:100%;
	height:100px;
}
.color-box:active{
	transform: scale(2,10) translate(0px,0);
}
.color-name-box{
	height:100px;
	width:50%;
	float:none;
	padding:0.01px 0 0 0%;
	border-right: .3rem solid rgba(10,10,10,15%);
}
.color-name-container{
	bottom:500px;
	border-top:none;
}
.text-align-bottom{
	position-relative;
	left:30%;
	font-weight:600;
	font-size:.5rem;
	top:.5%;
	line-height:220%;
	text-transform:uppercase;
	font:"FlashFont";
}
.project-header-type{
	font-size:3.5rem;
	overflow-wrap: break-word;
	word-wrap: break-word;
}

}
