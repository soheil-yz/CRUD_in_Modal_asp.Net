function Startloading(element = 'body') {
    $(element).waitMe({
        effect: 'bounce',
        text: 'Please Wait ...',
        bg: 'rgba(255, 255, 255, 0.7)',
        color: '#000'
    })
}

function CloseLoading(element = 'body') {
    $(element).waitMe('hide');
}


