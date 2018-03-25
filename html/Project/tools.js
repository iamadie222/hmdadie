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