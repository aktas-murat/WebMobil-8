var changeColor =()=>{

    var rangeRed=document.getElementById("range-red");
    var rangeGreen=document.getElementById("range-green");
    var rangeBlue=document.getElementById("range-blue");

     var pickerDiv=document.getElementById("picker-div");

     console.log([rangeRed.value, rangeGreen.value,rangeBlue.value]);
     //var color="rgb(" + rangeRed.value + ","+ rangeGreen.value + ","+rangeBlue.value+")";
     var color=`rgb(${rangeRed.value},${rangeGreen.value},${rangeBlue.value})`;
     var color=`rgb(${255-rangeRed.value},${255-rangeGreen.value},${255-rangeBlue.value})`;
     
     pickerDiv.innerHTML=color;
     pickerDiv.style.backgroundColor=color;
     pickerDiv.style.color=colorRev;

}

var copyClipboard=()=> { //arrow function
  
    var pickerDiv=document.getElementById("picker-div");
    navigator.clipboard.writeText(pickerDiv.innerHTML);
    // Swal.fire('Kopylandı:'+pickerDiv.innerHTML)
    Swal.fire({
        icon: 'info',
        title: 'Kopyalandı',
        text: pickerDiv.innerHTML,
        footer: 'Web Mobil 8 Sınıfı'
      })
  
}

var divMouseOver = () => { 
    var pickerDiv = document.getElementById("picker-div");
    
    pickerDiv.classList.add("animate__animated");
    pickerDiv.classList.add("animate__pulse");
}

var divMouseLeave = () => { 
    var pickerDiv = document.getElementById("picker-div");
    
    pickerDiv.classList.remove("animate__animated");
    pickerDiv.classList.remove("animate__pulse");
}

changeColor();