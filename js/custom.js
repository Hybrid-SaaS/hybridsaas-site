$(document).ready(function(e) {
	$('#header-part a.menu').click(function(){
		$('.nav-bar').slideToggle();	
	});
});

$(document).ready(function(e) {
    $('.flexslider').flexslider({
		animation: 'slide',
		animationLoop: true,
		directionNav: false,
		
	});
	
});

$(document).ready(function(e) {
    $('.flexslider2').flexslider({
		animation: 'slide',
		animationLoop: true,
		directionNav: true,
		controlNav: false,
		itemWidth: 120,
		itemMargin: 40,
		minItems: 6,
		maxItems: 10,
		move: 1
		
	});
	
});