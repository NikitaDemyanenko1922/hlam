
 function raschitat(){
    let re = /^\d+$/;
    let price = document.getElementById("price");
    let quantity = document.getElementById("quantity");
    let r = document.getElementById("result");
    if(re.test(price.value) && re.test(quantity.value)){
        alert(r.innerHTML = "��������� ������: " + parseFloat(price.value) * parseFloat(quantity.value) + " ���.");
    } else{
        alert(r.innerHTML = "������� ���������� ������");
    }
    return false;
  }

  window.addEventListener('DOMContentLoaded', function (_event) {
    console.log("DOM fully loaded and parsed");
    document.getElementById("my-button").addEventListener("click", raschitat);
  });