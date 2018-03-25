$("#cropImage").click(function(){
    
});
$("#cropImage").click(function(){

});
$("#cropImage").click(function(){

});


window.effectNow="";
$("#effectBlur").click(function(){
    effectNow="blur";
    applyEffect($("#workImage")[0],effectNow,20);
    setScaleMargin(20);
    $("#workScale").show();
});
$("#effectContrast").click(function(){
    effectNow="contrast";
    applyEffect($("#workImage")[0],effectNow,50)
    setScaleMargin(50);
    $("#workScale").show();
});
$("#effectBlackAndWhite").click(function(){
    effectNow="grayscale";
    applyEffect($("#workImage")[0],effectNow,100)
    setScaleMargin(100);
    $("#workScale").show();
});
$("#effectSaturate").click(function(){
    effectNow="saturate";
    applyEffect($("#workImage")[0],effectNow,50)
    setScaleMargin(50);
    $("#workScale").show();
});
$("#effectSepia").click(function(){
    effectNow="sepia";
    applyEffect($("#workImage")[0],effectNow,100)
    setScaleMargin(100);
    $("#workScale").show();
});
$("#effectHuerotate").click(function(){
    effectNow="hue-rotate";
    applyEffect($("#workImage")[0],effectNow,25);
    setScaleMargin(25);
    $("#workScale").show();
});

function applyEffect(element,effectName,per){
    var value=per;
    if(effectName=="blur"){
        value=(per/10)+"px";
    }
    else if(effectName=="hue-rotate"){
        value=(per * 3.6)+"deg";
    }
    else if(effectName=="saturate"){
        value=per/10;
    }
    else if(effectName=="contrast"||effectName=="sepia"||effectName=="grayscale"){
        value=per/100;
    }
    $(element).css("filter",effectName+"("+value+")");
}

$("#workCircle").on("mousedown",function(){
    $(document)[0].onmousemove=circleMouseMove;
});
$(document).on("mouseup",function(){
    $(document)[0].onmousemove=null;
});
$("#importImage").click(function(){
    $("#imageInput").click();
});
function circleMouseMove(e){
    e.stopPropagation();
    var newMargin=parseInt($("#workCircle").css("margin-left"))+e.movementX;
    if(newMargin<-10 || newMargin>390){
        return;
    }
    $("#workCircle").css("margin-left",newMargin);
    applyEffect($("#workImage")[0],effectNow,(newMargin-10)/4 );
}
function setScaleMargin(per){
    $("#workCircle").css("margin-left",(per *4)-10);
}


function saveImage(){
    canvas =document.createElement("canvas");
    canvas.height=$("#workImage").height();
    canvas.width=$("#workImage").width();
    var ctx=canvas.getContext("2d");
    ctx.drawImage($("#workImage")[0],0,0);
    ctx.filter = getComputedStyle($("#workImage")[0]).filter;
    const url = canvas.toDataURL(`image/png`);
    download(url,"lohar");
    
    $("#workArea").append(canvas)
}
function download(url, fullName) {
    const anchor = document.createElement('a')
    anchor.href = url
    anchor.setAttribute('download', fullName)
  
    anchor.click();
  }
  function download2(can){
  var link = document.createElement('a');
  link.href = can.toDataURL();
  link.download =  "asdfsdf.png";
  
  // create a mouse event
  var event = new MouseEvent('click');
  
  // dispatching it will open a save as dialog in FF
  link.dispatchEvent(event);
  }
  function screenshot(imgNode, format = 'png', quality = 0.97) {
    const canvas = document.createElement('canvas')
    window.canvas=canvas;
    canvas.width = imgNode.width
    canvas.height = imgNode.height
  
    const context = canvas.getContext('2d')
    context.filter = getComputedStyle(imgNode).filter
  
    imgNode.setAttribute('crossOrigin', 'anonymous')
  
    context.drawImage(imgNode, 0, 0, canvas.width, canvas.height)
    const url = canvas.toDataURL(`image/${format}`, quality)
  
    return {
      url,
      then: (cb) => {
        cb(url)
      },
      download: (name = 'image') => {
        download2(canvas, `${name}.${format}`)
      }
    }
  }
$("#imageInput").change(function(){
    var r=new FileReader();
    r.readAsDataURL(this.files[0]);
    r.onload=function(res){
        $("#workArea").empty()
        var img=new Image();
        img.src=res.target.result;
        img.id="workImage";
        $("#workArea").append(img); 
    }
});
$("#saveImage").click(function(){
    if($("#workImage").length==0){
        alert("select Image first");
        return;
    }
    screenshot($("#workImage")[0]).download();
    
});