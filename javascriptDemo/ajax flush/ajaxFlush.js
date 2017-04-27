var t = document.getElementById("progressText"); 
var bg = document.getElementById("progressBg"); 

function send(){ 
	t.innerHTML = "loading..."; 
	bg.style.width = "0px"; 
	var xhr = new window.XMLHttpRequest(); 

	if(!window.XMLHttpRequest){ 
		try { 
			xhr = new window.ActiveXObject("Microsoft.XMLHTTP"); 
		} catch(e) {} 
	}

	xhr.open("post","http://localhost:801/ChunkTest/chunk.jsp?count=6"); 

	var oldSize=0; 

	xhr.onreadystatechange = function(){ 
		if(xhr.readyState > 2){ 

			var tmpText = xhr.responseText.substring(oldSize); 
			oldSize = xhr.responseText.length; 

			if(tmpText.length > 0){ 
				// 设置文本 
				t.innerHTML = tmpText + "/6"; 
				// 设置进度条 
				var width = parseInt(tmpText)/6*300; 
				bg.style.width = width+"px"; 
			}
		}

		if(xhr.readyState == 4){ 
			// 请求执行完毕 
			t.innerHTML = "执行完毕"; 
			bg.style.width = "300px"; 
		}
	} 
	
}

xhr.send(null); 
