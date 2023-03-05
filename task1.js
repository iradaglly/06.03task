const fincodesarr=["7RFD8S6","1AXTHXT0","7NVBAYH"];
let flag=true;
const regex=new RegExp('[0-9|A-H|J-N|P-Z|a-h|j-n|p-z]{7}$')
let fincode=window.prompt("Enter fincode:");
while(flag){
if(regex.test(fincode)){
    for(let i=0;i<fincodesarr.length;i++){
        if(fincode==fincodesarr[i]){
    window.alert("user found"+" fincode-"+i);
        }
        
    }
}
else if(regex.test(fincode)){
    for(let i=0;i<fincodesarr.length;i++){//formati duzgun olan amma arraya daxil olmayan fincode daxil edende hec ne cixartmir//
        if(fincode!=fincodesarr[i]){

    window.alert("fincode not found");
    
        }
    }
}
else{
 window.alert("wrong format")
}
}




