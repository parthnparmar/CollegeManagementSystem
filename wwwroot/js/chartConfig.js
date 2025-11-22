// Chart.js configuration for analytics

function renderAttendanceChart(canvasId, labels, data) {
    const ctx = document.getElementById(canvasId).getContext('2d');
    new Chart(ctx, {
        type: 'bar',
        data: {
            labels: labels,
            datasets: [{
                label: 'Attendance %',
                data: data,
                backgroundColor: 'rgba(0,123,255,0.7)',
                borderColor: 'rgba(0,123,255,1)',
                borderWidth: 1
            }]
        },
        options: {
            scales: {
                y: {
                    beginAtZero: true,
                    max: 100
                }
            }
        }
    });
}
