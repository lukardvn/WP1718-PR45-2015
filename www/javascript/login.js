// odmah prilikom ucitavanja, cim je dokument "spreman"
$(document).ready(function(){
    $("#openLoginForm").on('click', function (e) {
	    SwitchForm();
	    //e.preventDefault();
    });
    $("#openRegistartionForm").on('click', function (e) {
	    SwitchForm();
	    //e.preventDefault();
    });
});

function SwitchForm() {
	$('body').toggleClass('prikazanaRegistracija');
	
	if ($('body').hasClass('prikazanaRegistracija')) {
		$('.registerFormContainer').hide(200);
		$('.loginFormContainer').show(200);
	} else {
		$('.loginFormContainer').hide(200);
		$('.registerFormContainer').show(200);
	}	
}

function ValidateForm(){
	if ($('body').hasClass('prikazanaRegistracija')){
		var korisnickoIme = $("#reg-username").val();
		var sifra = $("#reg-password").val();
		var sifra2 = $("#reg-password2").val();
		var ime = $("#reg-ime").val();
		var prezime = $("#reg-prezime").val();		
		var jmbg = $("#reg-jmbg").val();
		var telefon = $("#reg-telefon").val();
		var email = $("#reg-email").val();
		
		if (!CheckInputText(korisnickoIme)){
			alert("Korisnicko ime nije ispravno.");
			return false;
		}
		
		if (!CheckInputText(sifra)){
			alert("Sifra nije ispravna");
			return false;
		}
		
		if (!CheckInputText(sifra2)){
			alert("Ponovljena sifra nije ispravna");
			return false;
		}
		
		if (!CheckInputText(ime)){
			alert("Ime nije ispravno");
			return false;
		}
		
		if (!CheckInputText(prezime)){
			alert("Prezime nije ispravno");
			return false;
		}
		
		if (!CheckInputText(jmbg) || isNaN(jmbg) || jmbg.length != 13){
			alert("JMBG nije ispravan");
			return false;
		}
		
		if (!CheckInputText(telefon) || isNaN(telefon)){
			alert("Telefon nije ispravan");
			return false;
		}
		
		if (!CheckInputText(email)){
			alert("Email nije ispravan");
			return false;
		}
		
		if (sifra !== sifra2){
			alert("Sifre se ne slazu");
			return false;
		}
		
		return true;
	}
	else {
		var korisnickoIme = $("#login-username").val();
		var sifra = $("#login-password").val();
		
		if (!CheckInputText(korisnickoIme)){
			alert("Korisnicko ime nije ispravno!");
			return false;
		}
		
		if (!CheckInputText(sifra)){
			alert("Sifra nije ispravna");
			return false;
		}
		
		return true;
	}
}

function CheckInputText(tekst){
	if ($.trim(tekst) == ""){
		return false;
	}
	
	return true;
}