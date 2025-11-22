// Analytics page scripts
function showAttendancePercentage(studentId, percentage) {
    const el = document.getElementById(`attendance-${studentId}`);
    if(el) {
        el.innerText = percentage.toFixed(2) + "%";
    }
}
